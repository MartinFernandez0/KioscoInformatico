using KioscoInformaticoApp.Utils;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    //public class ProductosEnOfertaViewModel : ObjectNotification
    //{
    //    private GenericService<Producto> productoService = new GenericService<Producto>();

    //    private string filterProducts;
    //    public string FilterProducts
    //    {
    //        get { return filterProducts; }
    //        set
    //        {
    //            filterProducts = value;
    //            OnPropertyChanged();
    //            FiltarProductos();
    //        }
    //    }

    //    private ObservableCollection<Producto> productos;
    //    public ObservableCollection<Producto> Productos
    //    {
    //        get { return productos; }
    //        set
    //        {
    //            productos = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    //porque hacemos esto, porque lo dijo Gabriel
    //    //https://chatgpt.com/share/9ab527ab-34a6-426c-b7a7-362c38e460a7
    //    private bool _isRefreshing;
    //    public bool IsRefreshing
    //    {
    //        get => _isRefreshing;
    //        set
    //        {
    //            _isRefreshing = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    private List<Producto>? ProductListToFilter;

    //    private bool activityStart;
    //    public bool ActivityStart
    //    {
    //        get { return activityStart; }
    //        set
    //        {
    //            activityStart = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    public Command ObtenerProductosCommand { get; set; }
    //    public Command FiltrarProductosCommand { get; set; }

    //    public ProductosEnOfertaViewModel()
    //    {
    //        ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
    //        FiltrarProductosCommand = new Command(async () => await FiltarProductos());
    //        ObtenerProductos();
    //    }

    //    private async Task FiltarProductos()
    //    {
    //        var prductosFiltrados = ProductListToFilter.Where(p => p.Oferta && p.Nombre.ToUpper().Contains(FilterProducts.ToUpper()));
    //        Productos = new ObservableCollection<Producto>(prductosFiltrados);
    //    }

    //    private async Task ObtenerProductos()
    //    {
    //        FilterProducts = string.Empty;
    //        ActivityStart = true;
    //        ProductListToFilter = await productoService.GetAllAsync();
    //        Productos = new ObservableCollection<Producto>(ProductListToFilter);
    //        ActivityStart = false;
    //    }

    //}

    public class ProductosEnOfertaViewModel : ObjectNotification
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
                FiltarProductos();
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

        private List<Producto>? ProductListToFilter;

        private bool activityStart;
        public bool ActivityStart
        {
            get { return activityStart; }
            set
            {
                activityStart = value;
                OnPropertyChanged();
            }
        }

        public Command ObtenerProductosCommand { get; set; }
        public Command FiltrarProductosCommand { get; set; }

        public ProductosEnOfertaViewModel()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
            FiltrarProductosCommand = new Command(async () => await FiltarProductos());
            ObtenerProductos();
        }

        private async Task FiltarProductos()
        {
            if (ProductListToFilter != null)
            {
                var productosFiltrados = ProductListToFilter
                    .Where(p => p.Oferta &&
                                p.Nombre.ToUpper().Contains(FilterProducts.ToUpper()));
                Productos = new ObservableCollection<Producto>(productosFiltrados);
            }
        }

        private async Task ObtenerProductos()
        {
            FilterProducts = string.Empty;
            ActivityStart = true;
            ProductListToFilter = await productoService.GetAllAsync();

            // Filtrar los productos en oferta al obtener la lista
            var productosEnOferta = ProductListToFilter
                .Where(p => p.Oferta)
                .ToList();
            Productos = new ObservableCollection<Producto>(productosEnOferta);
            ActivityStart = false;
        }
    }

}



