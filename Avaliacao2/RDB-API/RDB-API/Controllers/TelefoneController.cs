using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RDB_API.Models.ClienteModels;
using RDB_API.Models.ClienteParams;
using RDB_API.Models.Enums;
using RDB_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDB_API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class TelefoneController : ControllerBase
    {
        private readonly TelefoneService _service;

        public TelefoneController(TelefoneService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Telefone> Get()
        {
            return _service.ListarTelefones();
        }

        [HttpGet("{id}")]
        public IEnumerable<Telefone> Get(int id)
        {
            return _service.ProcurarTelefonesCliente(id);
        }

        [HttpPost]
        public void Post([FromBody] Telefone telefone)
        {
            _service.AdicionarTelefone(telefone);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AtualizarTelefone telefone)
        {
            _service.AtualizarTelefone(id, telefone);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.ApagarTelefone(id);
        }
    }
}
