using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.Service;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClienteService _service;

        public ClientesController(ClienteService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.ListarClientes());
        }
        

        public IActionResult Clientes()
        {
            ClientesViewModel valores = new ClientesViewModel();
            valores.Clientes = _service.ListarClientes();
            return View(valores);
        }

        [HttpGet]
        public IActionResult AdicionarCliente()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//Impede ataque de falsificações de dados
        public IActionResult AdicionarCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _service.AdicionarCliente(cliente);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View(_service.ProcurarCliente(id.Value));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Atualizar(Cliente cliente,int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _service.AtualizarCliente(cliente);
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View(_service.ProcurarCliente(id.Value));
        }
        
        [HttpPost]
        [ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmarExcluir(int id)
        {
            _service.RemoverCliente(id);
            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult Ajax()
        {
            return Json(_service.ListarClientes());
        }
    }
}