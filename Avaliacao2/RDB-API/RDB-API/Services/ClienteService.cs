using Newtonsoft.Json;
using RDB_API.Models;
using RDB_API.Models.ClienteModels;
using RDB_API.Models.ClienteParams;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RDB_API.Services
{
    public class ClienteService
    {
        private readonly Context _context;

        public ClienteService(Context context)
        {
            this._context = context;
        }

        public IEnumerable<Cliente> ListarClientes()
        {
            return _context.Clientes.ToList();
        }

        public Cliente ProcurarCliente(int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            List<Endereco> enderecos = _context.Enderecos.Where(x => x.ClienteId == id).ToList();
            List<Telefone> telefones = _context.Telefones.Where(x => x.ClienteId == id).ToList();
            return cliente;
        }

        public void AdicionarCliente(ClienteCadastro clienteCadastro)
        {
            var cliente = new Cliente 
            {
                Nome = clienteCadastro.Nome,
                Documento = clienteCadastro.Documento
            };
            var endereco = new Endereco
            {
                Cep = clienteCadastro.Cep,
                Rua = clienteCadastro.Rua,
                Bairro = clienteCadastro.Bairro,
                Numero = clienteCadastro.NumeroCasa,
                Municipio = clienteCadastro.Municipio,
                Tipo = clienteCadastro.enderecoTipo,
                Cliente = cliente
            };
            var telefone = new Telefone
            {
                Numero = clienteCadastro.NumeroTelefone,
                Tipo = clienteCadastro.telefoneTipo,
                Cliente = cliente
            };

            _context.Enderecos.Add(endereco);
            _context.Telefones.Add(telefone);

            _context.SaveChanges();
        }

        public void AtualizarCliente(int id,AtualizarCliente cliente)
        {
            var clienteAtualizado = _context.Clientes.Find(id);
            clienteAtualizado.Nome = cliente.Nome;
            clienteAtualizado.Documento =cliente.Documento;
            _context.Clientes.Update(clienteAtualizado);
            _context.SaveChanges();
        }

        public void RemoverCliente(int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            _context.Remove(cliente);
            _context.SaveChanges();
        }

    }
}
