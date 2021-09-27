using RDB_API.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RDB_API.Models.ClienteModels
{
    public class Endereco
    {
        [Required]
        [Key]
        public int EnderecoId { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Municipio { get; set; }
        public EnderecoTipo Tipo { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }  //Chave estangeira de cliente
        [JsonIgnore]
        public Cliente Cliente { get; set; } //Propriedade de navegação unica
    }
}
