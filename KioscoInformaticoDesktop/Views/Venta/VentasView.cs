using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System.Diagnostics;


namespace KioscoInformaticoDesktop.GenerateCompraView
{
    public partial class VentasView : Form
    {
        ClienteService clienteService = new ClienteService();
        ProductoService productoService = new ProductoService();

        GenericService<Venta> ventaService = new GenericService<Venta>();

        Venta venta = new Venta();



        public VentasView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async void AjustePantalla()
        {
            Stopwatch relog = new Stopwatch();
            relog.Start();

            await Task.WhenAll
                (
                    Task.Run(async () => comboBoxCliente.DataSource = await clienteService.GetAllAsync()),
                    Task.Run(async () => comboBoxProducto.DataSource = await productoService.GetAllAsync())
                );

            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.SelectedIndex = -1;

            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "Id";
            comboBoxProducto.SelectedIndex = -1;

            comboBoxFormadePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));

            relog.Stop();
            Debug.Print($"Tiempo de carga de combos: {relog.ElapsedMilliseconds} ms");

            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            dataGridViewDetalleVenta.DataSource = venta.DetallesVenta.ToList();

        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProducto.SelectedIndex != -1)
            {
                Producto producto = (Producto)comboBoxProducto.SelectedItem;
                numericPrecio.Value = producto.Precio;
            }
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalleVenta = new DetalleVenta
            {
                Producto = (Producto)comboBoxProducto.SelectedItem,
                ProductoId = (int)comboBoxProducto.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value,
            };

            venta.DetallesVenta.Add(detalleVenta);
            dataGridViewDetalleVenta.DataSource = venta.DetallesVenta.ToList();
            comboBoxProducto.SelectedIndex = -1;
            comboBoxProducto.Focus();

            ActualizarTotalFactura();

        }

        private void ActualizarTotalFactura()
        {
            numericTotal.Value = venta.DetallesVenta.Sum(dv => dv.Cantidad * dv.PrecioUnitario);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetalleVenta.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de venta");
            }
            var detalleVenta = (DetalleVenta)dataGridViewDetalleVenta.CurrentRow.DataBoundItem;
            venta.DetallesVenta.Remove(detalleVenta);
            dataGridViewDetalleVenta.DataSource = venta.DetallesVenta.ToList();
        }

        private void dataGridViewDetalleVenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewDetalleVenta.OcultarColumnas(new string[] { "Id", "VentaId", "ProductoId", "Venta", "Eliminado" });
            //Boton intereactivo para boton eliminar
            btnQuitar.Enabled = dataGridViewDetalleVenta.RowCount > 0;

        }

        private async void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            //Cargamos los datos de la venta

            venta.ClienteId = (int)comboBoxCliente.SelectedValue;
            venta.Cliente = (Cliente)comboBoxCliente.SelectedItem;
            venta.FormaPago = (FormaDePagoEnum)comboBoxFormadePago.SelectedItem;
            venta.Fecha = DateTime.Now;

            venta.Total = numericTotal.Value;
            venta.Iva = venta.Total * 0.21m;
            //venta.Cliente = null;
            //venta.DetallesVenta.ToList().ForEach(dv => dv.Producto = null);
            //venta.DetallesVenta.ToList().ForEach(dv => dv.Venta = null);

            var nuevaVenta = await ventaService.AddAsync(venta);
            var FACVentasViewReport = new FACVentasViewReport(nuevaVenta);
            FACVentasViewReport.ShowDialog();


            MessageBox.Show("Venta registrada con exito");

        }
    }
}
