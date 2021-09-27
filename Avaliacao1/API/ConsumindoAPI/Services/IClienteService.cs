using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;
using API.Models.Enums;
using Refit;

namespace ConsumindoAPI.Services
{
    public interface IClienteService
    {
        [Get("/Api/Clientes")]
        Task<List<Cliente>> ListaDeClientes();

        [Get("/Api/Clientes/{id}")]
        Task<Cliente> BuscarCliente(int id);

        [Delete("/Api/Clientes/{id}")]
        Task<Cliente> RemoverCliente(int id);

        [Post("/Api/Clientes/adicionar/{nome},{porteEmpresa}")]
        Task<Cliente> AdicionarCliente(string nome, PorteEmpresa porteEmpresa);

        [Post("/Api/Clientes/atualizar/{id},{nome},{porteEmpresa}")]
        Task<Cliente> AtualizarCliente(int id, string nome, PorteEmpresa porteEmpresa);
    }
}