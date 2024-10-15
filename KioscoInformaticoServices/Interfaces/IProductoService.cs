using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KioscoInformaticoServices.Interfaces
{
    public interface IProductoService : IGenericService<Producto>
    {
        public Task<List<Producto>?> GetAllInOfferAsync();
    }
}
