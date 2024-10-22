using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using System.Text.Json;

namespace KioscoInformaticoServices.Services
{
    public class ClienteService : GenericService<Cliente>, IClienteService
    {
        public async Task<List<Cliente>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Cliente>>(content, options);
        }
    }
}
