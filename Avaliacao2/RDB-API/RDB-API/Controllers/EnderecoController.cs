using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RDB_API.Models.ClienteModels;
using RDB_API.Models.ClienteParams;
using RDB_API.Models.Enums;
using RDB_API.Services;
using System.Collections.Generic;


namespace RDB_API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly EnderecoService _service;

        public EnderecoController(EnderecoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Endereco> Get()
        {
            return _service.ListarEnderecos();
        }

        [HttpGet("{id}")]
        public List<Endereco> Get(int id)
        {
            return _service.ProcurarEnderecosCliente(id);
        }

        [HttpPost]
        public void Post(Endereco endereco)
        {
            _service.AdicionarEndereco(endereco);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AtualizarEndereco endereco)
        {
            _service.AtualizarEndereco(id, endereco);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.ApagarEndereco(id);
        }
    }
}
