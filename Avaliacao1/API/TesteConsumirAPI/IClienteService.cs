using API.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TesteConsumirAPI
{
    public interface IClienteService
    {
        [Get("/Api/Clientes")]
        Task<List<Cliente>> GetListaClientes();


        [Get("/Api/Clientes/{id}")]
        Task<Cliente> GetClienteAsync(int id);

        [Delete("/Api/Clientes/{id}")]
        Task<Cliente> DeleteCliente(int id);

        [Post("/Api/Clientes/adicionar/")]
        Task<Cliente> AdicionarCliente(string nome, int porteEmpresa);

        [Post("/Api/Clientes/atualizar/{id},{nome},{porteEmpresa}")]
        Task<Cliente> AtualizarCliente(int id,string nome, int porteEmpresa);
    }
}
