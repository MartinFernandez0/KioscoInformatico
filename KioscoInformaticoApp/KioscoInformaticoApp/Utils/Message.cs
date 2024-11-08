using CommunityToolkit.Mvvm.Messaging.Messages;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Utils
{
    class Message : ValueChangedMessage<string>
    {
        public Producto ProductoAEditar { get; set; }
        public Message(string value) : base(value)
        {

        }
    }
}