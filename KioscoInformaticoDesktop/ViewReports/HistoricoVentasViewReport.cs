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
    public partial class HistoricoVentasViewReport : Form
    {
        ReportViewer reporte;
        private List<Venta> listVentas;
        string tituloInforme;
        public HistoricoVentasViewReport(List<Venta> ventas, string tituloInforme)
        {
            InitializeComponent();
            listVentas = ventas;
            this.tituloInforme = tituloInforme;
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void HistoricoVentasViewReport_Load(object sender, EventArgs e)
        {
             reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.HistoricoVentasReport.rdlc";

            var ventas = listVentas.OrderBy(venta=>venta.FormaPago).Select(v => new
            {
                Id = v.Id,
                Fecha = v.Fecha,
                NombreCliente = v.Cliente.Nombre,
                Iva = v.Iva,
                FormaPago = v.FormaPago.ToString(),
                Total = v.Total
            }).ToList();

            reporte.LocalReport.SetParameters(new ReportParameter("TituloInforme", tituloInforme));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVentas", ventas));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
