using API.Models;
using API.Models.Enums;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsumindoAPI.Services
{
    public class ClienteServices
    {
        private const string URL = "https://localhost:44391";

        public async Task<Cliente> BuscarCliente(int id)
        {
            try
            {
                var resultado = RestService.For<IClienteService>(URL);
                var cliente = await resultado.BuscarCliente(id);
                return cliente;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Cliente();
            }
        }

        public async Task<List<Cliente>> ListaDeClientes()
        {
            try
            {
                var resultado = RestService.For<IClienteService>(URL);
                var cliente = await resultado.ListaDeClientes();
                return cliente;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Cliente>();
            }
        }

        public async Task RemoverCliente(int id)
        {
            try
            {
                var resultado = RestService.For<IClienteService>(URL);
                var cliente = await resultado.RemoverCliente(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task AdicionarCliente(string nome, PorteEmpresa porteEmpresa)
        {
            try
            {
                var resultado = RestService.For<IClienteService>(URL);
                await resultado.AdicionarCliente(nome,porteEmpresa);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task AtualizarCliente(int id,string nome, PorteEmpresa porteEmpresa)
        {
            try
            {
                var resultado = RestService.For<IClienteService>(URL);
                await resultado.AtualizarCliente(id, nome, porteEmpresa);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
