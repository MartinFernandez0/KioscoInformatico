using KioscoInformaticoApp.ViewModels.Productos;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;

public partial class AddEditProductoView : ContentPage
{
	public AddEditProductoView()
	{
		InitializeComponent();
	}
    public AddEditProductoView(Producto productoAEditar)
    {
        InitializeComponent();
        var viemodel = this.BindingContext as AddEditProductoViewModel;
        viemodel.editProduct = productoAEditar;

    }
}