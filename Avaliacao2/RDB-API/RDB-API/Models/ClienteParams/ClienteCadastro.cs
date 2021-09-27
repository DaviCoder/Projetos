using RDB_API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDB_API.Models.ClienteParams
{
    public class ClienteCadastro
    {
        public string Nome { get; set; }
        public string Documento { get; set; }

        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int NumeroCasa { get; set; }
        public string Municipio { get; set; }
        public EnderecoTipo enderecoTipo { get; set; }

        public string NumeroTelefone { get; set; }
        public TelefoneTipo telefoneTipo { get; set; }

    }
}
