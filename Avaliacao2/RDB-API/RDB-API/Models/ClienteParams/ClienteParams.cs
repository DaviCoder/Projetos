using RDB_API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDB_API.Models.ClienteParams
{
    public class AtualizarCliente
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
    }
    public class AtualizarEndereco
    {
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Municipio { get; set; }
        public EnderecoTipo Tipo { get; set; }
    }
    public class AtualizarTelefone
    {
        public string Numero { get; set; }
        public TelefoneTipo Tipo { get; set; }
    }
}