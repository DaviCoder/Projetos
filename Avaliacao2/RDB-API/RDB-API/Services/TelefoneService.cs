using RDB_API.Models;
using RDB_API.Models.ClienteModels;
using RDB_API.Models.ClienteParams;
using RDB_API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDB_API.Services
{
    public class TelefoneService
    {
        private readonly Context _context;

        public TelefoneService(Context context)
        {
            _context = context;
        }

        public IEnumerable<Telefone> ListarTelefones()
        {
            return _context.Telefones.ToList();
        }

        public void AdicionarTelefone(Telefone telefone)
        {
            _context.Telefones.Add(telefone);
            _context.SaveChanges();
        }

        public List<Telefone> ProcurarTelefonesCliente(int id)
        {
            List<Telefone> telefones = _context.Telefones.Where(x => x.ClienteId == id).ToList();
            return telefones;
        }

        public void AtualizarTelefone(int id, AtualizarTelefone telefone)
        {
            var telefoneAtualizado = _context.Telefones.Find(id);
            telefoneAtualizado.Numero = telefone.Numero;
            telefoneAtualizado.Tipo = telefone.Tipo;
            _context.Telefones.Update(telefoneAtualizado);
            _context.SaveChanges();
        }

        public void ApagarTelefone(int id)
        {
            Telefone telefone = _context.Telefones.Where(x => x.TelefoneId == id).FirstOrDefault();
            _context.Telefones.Remove(telefone);
            _context.SaveChanges();
        }
    }
}
