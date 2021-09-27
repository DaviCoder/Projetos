using API.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TesteConsumirAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            bool sair = false;
            Console.WriteLine("´´´´´´´´Consumindo a API pelo Console´´´´´´´´");
            while (!sair)
            {
                Console.WriteLine("Escolhe uma opção \n1-Listar todos os clientes\n2-Procurar por um cliente\n3-Remover um cliente\n4-Adicionar um cliente\n5-Adicionar um cliente\n6-Sair");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        var lista = await ListaDeClientes();
                        foreach (var cli in lista)
                        {
                            Console.WriteLine(cli.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o ID do cliente: ");
                        int id = int.Parse(Console.ReadLine());
                        var cliente = await BuscarCliente(id);
                        Console.WriteLine("Nome do cliente: "+ cliente.Nome);
                        break;
                    case 3:
                        Console.WriteLine("Digite o ID do cliente: ");
                        int idr = int.Parse(Console.ReadLine());
                        await DeletarCliente(idr);
                        break;
                    case 4:
                        Console.WriteLine("Digite o nome do cliente: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Porte da empresa: 0 = Pequeno, 1 = Medio, 2=Grande ");
                        int porte = int.Parse(Console.ReadLine());
                        await AdicionarCliente(nome, porte);
                        break;
                    case 5:
                        Console.WriteLine("Digite o ID do cliente: ");
                        int ida = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do cliente: ");
                        string nomea = Console.ReadLine();
                        Console.WriteLine("Porte da empresa: 0 = Pequeno, 1 = Medio, 2=Grande ");
                        int portea = int.Parse(Console.ReadLine());
                        await AtualizarCliente(ida,nomea, portea);
                        break;
                    case 6:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Digite um opção valida!");
                        break;
                }
            }            
        }

        static async Task<Cliente> BuscarCliente(int id)
        {
            try
            {
                var resultado = RestService.For<IClienteService>("https://localhost:44391");
                var cliente = await resultado.GetClienteAsync(id);
                return cliente;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Cliente();
            }
        }

        static async Task<List<Cliente>> ListaDeClientes()
        {
            try
            {
                var resultado = RestService.For<IClienteService>("https://localhost:44391");
                var cliente = await resultado.GetListaClientes();
                return cliente;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Cliente>();
            }
        }

        static async Task DeletarCliente(int id)
        {
            try
            {
                var resultado = RestService.For<IClienteService>("https://localhost:44391");
                await resultado.DeleteCliente(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static async Task AdicionarCliente(string nome, int porteEmpresa)
        {
            try
            {
                var resultado = RestService.For<IClienteService>("https://localhost:44391");
                var cliente = await resultado.AdicionarCliente(nome,porteEmpresa);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static async Task AtualizarCliente(int id, string nome, int porteEmpresa)
        {
            try
            {
                var resultado = RestService.For<IClienteService>("https://localhost:44391");
                var cliente = await resultado.AtualizarCliente(id, nome, porteEmpresa);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
