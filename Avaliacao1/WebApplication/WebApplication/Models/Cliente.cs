using System.ComponentModel.DataAnnotations;
using WebApplication.Models.Enums;
using WebApplication.Models.Validation;

namespace WebApplication.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio!")]
        [StringLength(100,ErrorMessage = "Limite de tamanho alcançado!")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio!")]
        [Porte(ErrorMessage = "Apenas essas opções são aceitas: Grande, Medio, Pequeno")]
        public PorteEmpresa PorteEmpresa { get; set; }
        
        public Cliente()
        {
        }

        public Cliente(int id, string nome, PorteEmpresa porteEmpresa)
        {
            ClienteId = id;
            Nome = nome;
            PorteEmpresa = porteEmpresa;
        }

        public override string ToString()
        {
            return ClienteId +" / "+ Nome+" / "+PorteEmpresa;
        }
    }
}