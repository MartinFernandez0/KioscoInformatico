using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Utils;
using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp
{
    public partial class KioscoShell : Shell
    {
        public KioscoShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral

            /////CÓDIGO QUE para preparar la recepción de mensajes y la llamada al método RecibirMensaje
            WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
            {
                OnReceiveMessage(mensaje);
            });
        }

        private void OnReceiveMessage(Message mensaje)
        {
            if (mensaje.Value == "AbrirProductos")
            {
                //await Navigation.PushAsync(new ProductosView());
            }
            if (mensaje.Value == "AbrirOfertas")
            {
                //await Navigation.PushAsync(new ProductosEnOferta());
            }
            if (mensaje.Value == "AgregarProducto")
            {
                //await Navigation.PushAsync(new AddEditProductoView());
            }
            if (mensaje.Value == "EditarProducto")
            {
                //await Navigation.PushAsync(new AddEditProductoView(mensaje.ProductoAEditar));
            }
        }


        // Metodos para que el Iniciar sesion se apage y encienda
        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as KioscoShellViewModel;
            viewmodel.IsUserLogout = false;
        }
        public void DisableAppAfterLogin()
        {
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }
    }
}
