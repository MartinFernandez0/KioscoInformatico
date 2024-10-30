using KioscoInformaticoServices.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.ViewReports
{
    public partial class FACCompraViewReport : Form
    {
        ReportViewer reporte;
        private Compra? nuevaCompra;

        public FACCompraViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        public FACCompraViewReport(Compra? nuevaCompra)
        {
            InitializeComponent();
            this.nuevaCompra = nuevaCompra;

            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);

        }
        private void FacturaCompraViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaCompraReport.rdlc";
            var compra = new List<object> { new { Id = nuevaCompra.Id, Fecha = nuevaCompra.Fecha, NombreCliente = nuevaCompra.Proveedor.Nombre, Iva = nuevaCompra.Iva, FormaPago = nuevaCompra.FormaDePago, Total = nuevaCompra.Total } };
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCompras", compra));

            var detallesCompra = nuevaCompra.Detallecompra.Select(dc => new { NombreProducto = dc.Producto.Nombre, PrecioUnitario = dc.PrecioUnitario, Cantidad = dc.Cantidad, SubTotal = dc.Subtotal });
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesCompra", detallesCompra));

            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
