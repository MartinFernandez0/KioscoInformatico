using KioscoInformaticoDesktop.GenerateCompraView;
using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoDesktop.Views;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void menuItemLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesView localidadesView = new LocalidadesView();
            localidadesView.ShowDialog();
        }

        private void menuItemProductos_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir del sistema?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuItemClientes_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void menuItemProveedores_Click(object sender, EventArgs e)
        {
            ProveedoresView proveedoresView = new ProveedoresView();
            proveedoresView.ShowDialog();
        }

        private void MenuItemLocalidadesReport_Click(object sender, EventArgs e)
        {
            LocalidadesViewReport localidadesViewReport = new LocalidadesViewReport();
            localidadesViewReport.ShowDialog();
        }

        private void MenuItemClientesReport_Click(object sender, EventArgs e)
        {
            ClientesViewReport clientesViewReport = new ClientesViewReport();
            clientesViewReport.ShowDialog();
        }

        private void MenuItemVentas_Click(object sender, EventArgs e)
        {
            VentasView ventasView = new VentasView();
            ventasView.ShowDialog();
        }

        private void MenuItemCompras_Click(object sender, EventArgs e)
        {
            ComprasView comprasView = new ComprasView();
            comprasView.ShowDialog();
        }
    }
}
