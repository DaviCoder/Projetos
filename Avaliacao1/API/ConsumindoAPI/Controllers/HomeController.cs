using API.Models;
using API.Models.Enums;
using ConsumindoAPI.Models;
using ConsumindoAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumindoAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ClienteServices _cliente;

        public HomeController(ILogger<HomeController> logger, ClienteServices cliente)
        {
            _logger = logger;
            _cliente = cliente;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> ListarClientes()
        {
            List<Cliente> cliente = await _cliente.ListaDeClientes();
            ViewData["CLientes"] = cliente;
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> BuscarCliente(int ClienteId)
        {
            List<Cliente> clientes = await _cliente.ListaDeClientes();
            if (clientes.Find(x => x.ClienteId == ClienteId) == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                Cliente cliente = await _cliente.BuscarCliente(ClienteId);
                return PartialView(cliente);
            }                 
        }

        [HttpGet]
        public async Task<IActionResult> RemoverCliente(int ClienteId)
        {
            List<Cliente> clientes = await _cliente.ListaDeClientes();
            if (clientes.Find(x => x.ClienteId == ClienteId) == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                await _cliente.RemoverCliente(ClienteId);
                return RedirectToAction(nameof(ListarClientes));
            }            
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarCliente(string nome, PorteEmpresa porteEmpresa)
        {
            await _cliente.AdicionarCliente(nome, porteEmpresa);
            return RedirectToAction(nameof(ListarClientes));
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarCliente(int clienteId, string nome, PorteEmpresa porteEmpresa)
        {
            await _cliente.AtualizarCliente(clienteId, nome, porteEmpresa);
            return RedirectToAction(nameof(ListarClientes));
        }
    }
}
