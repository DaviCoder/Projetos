using RDB_API.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RDB_API.Models.ClienteModels
{
    public class Telefone
    {
        [Key]
        public int TelefoneId { get; set; }
        public string Numero { get; set; }
        public TelefoneTipo Tipo { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; } //Chave estrangeira de cliente
        [JsonIgnore]
        public Cliente Cliente { get; set; } //Propriedade de navegação unica
    }
}
