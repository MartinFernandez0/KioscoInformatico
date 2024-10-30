using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ComprasView : Form
    {
        ProductoService productoService = new ProductoService();
        GenericService<Compra> compraService = new GenericService<Compra>();
        GenericService<Proveedor> proveedorService = new GenericService<Proveedor>();
        Compra compra = new Compra();
        public ComprasView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async void AjustePantalla()
        {
            Stopwatch reloj = new Stopwatch();
            reloj.Start();

            #region Carga de combos
            await Task.WhenAll
            (
                   Task.Run(async () => comboBoxProveedor.DataSource = await proveedorService.GetAllAsync()),
                   Task.Run(async () => comboBoxProducto.DataSource = await productoService.GetAllAsync())
            );

            comboBoxProveedor.DisplayMember = "Nombre";
            comboBoxProveedor.ValueMember = "Id";
            comboBoxProveedor.SelectedIndex = -1;

            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "Id";
            comboBoxProducto.SelectedIndex = -1;

            comboBoxFormadePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));
            #endregion

            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            gridDetalleCompras.DataSource = compra.Detallecompra.ToList();

            reloj.Stop();
            Debug.Print($"Tiempo de carga de combos: {reloj.ElapsedMilliseconds} ms");
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProducto.SelectedIndex != -1)
            {
                Producto producto = (Producto)comboBoxProducto.SelectedItem;
                numericPrecio.Value = producto.Precio;
            }
            btnAgregar.Enabled = comboBoxProducto.SelectedIndex != -1;
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void ActualizarTotalFactura()
        {
            numericTotal.Value = compra.Detallecompra.Sum(dc => dc.Subtotal);
        }

        private void gridDetalleCompras_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDetalleCompras.OcultarColumnas(new string[] { "Id", "CompraId", "Compra", "ProductoId", "Eliminado" });
            btnQuitar.Enabled = gridDetalleCompras.Rows.Count > 0;
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var detalleCompra = new DetalleCompra
            {
                Producto = (Producto)comboBoxProducto.SelectedItem,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value
            };
            compra.Detallecompra.Add(detalleCompra);
            gridDetalleCompras.DataSource = compra.Detallecompra.ToList();
            comboBoxProducto.SelectedIndex = -1;
            comboBoxProducto.Focus();
            ActualizarTotalFactura();
        }

        private void btnQuitar_Click_1(object sender, EventArgs e)
        {
            if (gridDetalleCompras.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de compra para quitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var detalleCompra = (DetalleCompra)gridDetalleCompras.CurrentRow.DataBoundItem;
            compra.Detallecompra.Remove(detalleCompra);
            gridDetalleCompras.DataSource = compra.Detallecompra.ToList();
            ActualizarTotalFactura();

        }

        private async void btnFinalizarCompra_Click_1(object sender, EventArgs e)
        {
            //cargamos datos a la compra
            compra.ProveedorId = (int)comboBoxProveedor.SelectedValue;
            compra.Proveedor = (Proveedor)comboBoxProveedor.SelectedItem;
            compra.FormaDePago = (FormaDePagoEnum)comboBoxFormadePago.SelectedItem;
            compra.Fecha = DateTime.Now;

            compra.Total = (int)numericTotal.Value;
            compra.Iva = (int)(compra.Total * 0.21m);
            var nuevaCompra = await compraService.AddAsync(compra);
            var facturaCompraViewReport = new FACCompraViewReport(nuevaCompra);
            facturaCompraViewReport.ShowDialog();

        }
    }
}
