    using CommunityToolkit.Mvvm.ComponentModel;
using KioscoInformaticoApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using CommunityToolkit.Mvvm.Messaging;

namespace KioscoInformaticoApp.ViewModels
{
    public class ProductosViewModel : ObjectNotification
    {
        private GenericService<Producto> productoService = new GenericService<Producto>();

        private string filterProducts;
        public string FilterProducts
        {
            get { return filterProducts; }
            set
            {
                filterProducts = value;
                OnPropertyChanged();
                _ = FiltarProductos();
            }
        }

        //porque hacemos esto, porque lo dijo Gabriel
        //https://chatgpt.com/share/9ab527ab-34a6-426c-b7a7-362c38e460a7
        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Producto> productos;
        public ObservableCollection<Producto> Productos
        {
            get { return productos; }
            set
            {
                productos = value;
                OnPropertyChanged();
            }
        }

        private List<Producto>? ProductListToFilter;
        private Producto selectedProducto;
         public Producto SelectedProducto
        {
            get { return selectedProducto; }
            set 
            {
                selectedProducto = value;
                OnPropertyChanged();
                EditarProductoCommand.ChangeCanExecute();
            }
        }

        public Command ObtenerProductosCommand { get; set; }
        public Command FiltrarProductosCommand { get; set; }
        public Command AgregarProductoCommand { get; set; }
        public Command EditarProductoCommand { get; set; }

        public ProductosViewModel()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
            FiltrarProductosCommand = new Command(async () =>  await FiltarProductos());
            AgregarProductoCommand = new Command(async () => await AgregarProducto());
            EditarProductoCommand = new Command(async (obj) => await EditarProducto(), PermitirEditar);
            ObtenerProductos();
        }

        private bool PermitirEditar(object arg)
        {
            return selectedProducto != null;
        }

        private async Task EditarProducto()
        {
            WeakReferenceMessenger.Default.Send(new Message("EditarProducto") { ProductoAEditar = SelectedProducto});
            EditarProductoCommand.ChangeCanExecute();
        }

        private async Task AgregarProducto()
        {
            WeakReferenceMessenger.Default.Send(new Message("AgregarProducto"));
        }

        private async Task FiltarProductos()
        {
            var prductosFiltrados = ProductListToFilter.Where(p => p.Nombre.ToUpper().Contains(FilterProducts.ToUpper()));
            Productos = new ObservableCollection<Producto>(prductosFiltrados);
        }

        public async Task ObtenerProductos()
        {
            FilterProducts = string.Empty;
            IsRefreshing = true;
            ProductListToFilter = await productoService.GetAllAsync();
            Productos = new ObservableCollection<Producto>(ProductListToFilter);
            IsRefreshing = false;
        }

    }
}
