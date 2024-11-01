using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;

public partial class AddEditProductoView : ContentPage
{
	public AddEditProductoView()
	{
		InitializeComponent();
	}
    public AddEditProductoView(Producto producto)
    {
        InitializeComponent();
        var viewModel = this.BindingContext as AddEditProductoViewModel;
        viewModel.EditProduct = producto;
    }
}