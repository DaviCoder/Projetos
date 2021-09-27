using Newtonsoft.Json;
using RDB_API.Models.ClienteModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RDB_API.Models
{
    public class Cliente
    {
        [Required]
        [Key]
        [JsonProperty("clienteId")]
        public int ClienteId { get; set; }
        [Required]
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [Required]
        [JsonProperty("documento")]
        public string Documento { get; set; }
        [Required]
        public ICollection<Endereco> Enderecos { get; set; } //Propriedade de navegação de coleção
        [Required]
        public ICollection<Telefone> Telefones { get; set; } //Propriedade de navegação de coleção

    }
}
