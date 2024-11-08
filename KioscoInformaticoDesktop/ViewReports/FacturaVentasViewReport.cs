using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
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
    public partial class FacturaVentasViewReport : Form
    {
        ReportViewer reporte;
        private Venta? nuevaVenta;

        //GenericService<DetalleVenta> detalleVentaService = new GenericService<DetalleVenta>();

        public FacturaVentasViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        public FacturaVentasViewReport(Venta? nuevaVenta)
        {
            
            InitializeComponent();
            this.nuevaVenta = nuevaVenta;
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void FacturaVentasViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaVentaReport.rdlc";
            var venta = new List<object> { new { Id = nuevaVenta.Id, Fecha = nuevaVenta.Fecha, NombreCliente = nuevaVenta.Cliente.Nombre, Iva = nuevaVenta.Iva, FormaPago = nuevaVenta.FormaPago.ToString(), Total = nuevaVenta.Total } } ;
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVenta", venta));

            var detallesVenta = nuevaVenta.Detallesventa.Select(dv => new { NombreProducto = dv.Producto.Nombre, PrecioUnitario = dv.PrecioUnitario, Cantidad = dv.Cantidad, SubTotal = dv.Subtotal });
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesVenta", detallesVenta));

            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
