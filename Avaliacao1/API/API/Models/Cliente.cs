using System.ComponentModel.DataAnnotations;
using API.Models.Enums;
using API.Models.Validation;
using Newtonsoft.Json;

namespace API.Models
{
    public class Cliente
    {
        [Key]
        [JsonProperty("clienteId")]
        public int ClienteId { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio!")]
        [StringLength(100,ErrorMessage = "Limite de tamanho alcançado!")]
        [JsonProperty("nome")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio!")]
        [Porte(ErrorMessage = "Apenas essas opções são aceitas: Grande, Medio, Pequeno")]
        [JsonProperty("porteEmpresa")]
        public PorteEmpresa PorteEmpresa { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, PorteEmpresa porteEmpresa)
        {
            Nome = nome;
            PorteEmpresa = porteEmpresa;
        }

        public Cliente(int clienteId, string nome, PorteEmpresa porteEmpresa)
        {
            ClienteId = clienteId;
            Nome = nome;
            PorteEmpresa = porteEmpresa;
        }

        public override string ToString()
        {
            return "ID: " + ClienteId + "   |Nome: " + Nome + "   |Porte da empresa: " + PorteEmpresa;
        }
    }
}