using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RDB_API.Models;
using RDB_API.Models.ClienteParams;
using RDB_API.Services;
using System.Collections.Generic;

namespace RDB_API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _service;

        public ClienteController(ClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {

            return _service.ListarClientes();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _service.ProcurarCliente(id);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] ClienteCadastro cliente)
        {
            _service.AdicionarCliente(cliente);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] AtualizarCliente cliente)
        {
            _service.AtualizarCliente(id,cliente);
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.RemoverCliente(id);
        }
    }
}
