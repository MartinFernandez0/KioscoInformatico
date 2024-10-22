using KioscoInformaticoServices.Models;

namespace KioscoInformaticoServices.Interfaces
{
    public interface IClienteService : IGenericService<Cliente>
    {
        public Task<List<Cliente>?> GetAllAsync(string? filtro);
    }
}
