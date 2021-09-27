using RDB_API.Models;
using RDB_API.Models.ClienteModels;
using RDB_API.Models.ClienteParams;
using RDB_API.Models.Enums;
using System.Collections.Generic;
using System.Linq;

namespace RDB_API.Services
{
    public class EnderecoService
    {
        private readonly Context _context;

        public EnderecoService(Context context)
        {
            _context = context;
        }
        public IEnumerable<Endereco> ListarEnderecos()
        {
            return _context.Enderecos.ToList();
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
        }

        public List<Endereco> ProcurarEnderecosCliente(int id)
        {
            List<Endereco> enderecos = _context.Enderecos.Where(x => x.ClienteId == id).ToList();
            return enderecos;
        }

        public void AtualizarEndereco(int id, AtualizarEndereco endereco)
        {
            var enderecoAtualizado = _context.Enderecos.Find(id);
            enderecoAtualizado.Cep = endereco.Cep;
            enderecoAtualizado.Rua = endereco.Rua;
            enderecoAtualizado.Bairro = endereco.Bairro;
            enderecoAtualizado.Numero = endereco.Numero;
            enderecoAtualizado.Municipio = endereco.Municipio;
            _context.Enderecos.Update(enderecoAtualizado);
            _context.SaveChanges();
        }

        public void ApagarEndereco(int id)
        {
            Endereco endereco = _context.Enderecos.Where(x => x.EnderecoId == id).FirstOrDefault();
            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();
        }
    }
}
