using System.Collections.Generic;
using API.Models;
using API.Models.Enums;
using API.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private ClienteService _service;

        public ClientesController(ClienteService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public List<Cliente> ListarClientes()
        {
            return _service.ListarClientes();
        }
        
        [HttpGet("{id:int}")]
        public Cliente ProcurarCliente(int? id)
        {
            if (id==null) return new Cliente();
            
            return _service.ProcurarCliente(id.Value);
        }

        [HttpDelete("{id:int}")]
        public void RemoverCliente(int? id)
        {
            if (id == null) return;

            _service.RemoverCliente(id.Value);
        }

        [HttpPost("adicionar/{nome},{porteEmpresa}")]
        public void AdicionarCliente(string nome, PorteEmpresa porteEmpresa)
        {
            _service.AdicionarCliente(new Cliente(nome, porteEmpresa));
        }

        [HttpPost("atualizar/{id:int},{nome},{porteEmpresa}")]
        public void AtualizarCliente(int id,string nome,PorteEmpresa porteEmpresa)
        {
            Cliente cliente = _service.ProcurarCliente(id);
            cliente.Nome = nome;
            cliente.PorteEmpresa = porteEmpresa;
            _service.AtualizarCliente(cliente);
        }

        
    }
}