using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
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
    public partial class FACVentasViewReport : Form
    {
        ReportViewer reporte;
        private Venta? nuevaVenta;

        public FACVentasViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);

        }

        public FACVentasViewReport(Venta? nuevaVenta)
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void FACVentasViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaVentaReport.rdlc";

            var venta = new
            {
                id = nuevaVenta.Id,
                fecha = nuevaVenta.Fecha,
                cliente = nuevaVenta.Cliente.Nombre,
                formaDePago = nuevaVenta.FormaPago,
                total = nuevaVenta.Total
            };

            var detallesVenta = nuevaVenta.DetallesVenta.Select(details => new
            {
                producto = details.Producto.Nombre,
                precio = details.PrecioUnitario,
                cantidad = details.Cantidad,
                subtotal = details.SubTotal
            });


            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVentas", venta));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetalleVenta", detallesVenta));

            reporte.SetDisplayMode(DisplayMode.PrintLayout);

            //ponemos el zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;

            reporte.RefreshReport();

        }
    }
}
