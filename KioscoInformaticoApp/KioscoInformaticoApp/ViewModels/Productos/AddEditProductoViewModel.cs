using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels.Productos
{
    public class AddEditProductoViewModel : ObjectNotification
    {
        ProductoService productoService = new ProductoService();
        private Producto EditProduct;

        public Producto editProduct
        {
            get { return EditProduct; }
            set
            {
                EditProduct = value;
                OnPropertyChanged();
                SettingData();
            }
        }

        private void SettingData()
        {
            Nombre = EditProduct.Nombre;
            Precio = EditProduct.Precio;
            Oferta = EditProduct.Oferta;
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                OnPropertyChanged();
            }
        }

        private bool oferta;

        public bool Oferta
        {
            get { return oferta; }
            set
            {
                oferta = value;
                OnPropertyChanged();
            }
        }

        public Command SaveProductCommand { get; }

        public AddEditProductoViewModel()
        {
            SaveProductCommand = new Command(async () => await SaveProduct());
        }

        private async Task SaveProduct()
        {
            if (EditProduct != null)
            {
                editProduct.Nombre = Nombre;
                editProduct.Precio = Precio;
                editProduct.Oferta = Oferta;
                await productoService.UpdateAsync(EditProduct);
            }
            else
            {
                editProduct = new Producto
                {
                    Nombre = Nombre,
                    Precio = Precio,
                    Oferta = Oferta
                };
                await productoService.AddAsync(EditProduct);
            }
        }
    }
}


