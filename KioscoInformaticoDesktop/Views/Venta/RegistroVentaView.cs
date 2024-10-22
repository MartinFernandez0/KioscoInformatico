using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using Nest;
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

namespace KioscoInformaticoDesktop.GenerateCompraView
{
    public partial class RegistroVentaView : Form
    {
        ClienteService clienteService = new ClienteService();
        ProductoService productoService = new ProductoService();


        public RegistroVentaView()
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
    }
}
