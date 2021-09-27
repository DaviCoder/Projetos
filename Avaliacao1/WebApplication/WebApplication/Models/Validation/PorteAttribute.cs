using System.ComponentModel.DataAnnotations;
using WebApplication.Models.Enums;

namespace WebApplication.Models.Validation
{
    public class PorteAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Cliente cliente = (Cliente)validationContext.ObjectInstance;
            if (cliente.PorteEmpresa == PorteEmpresa.Grande ||
                cliente.PorteEmpresa == PorteEmpresa.Medio ||
                cliente.PorteEmpresa == PorteEmpresa.Pequeno)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Apenas essas opções são aceitas: Grande, Medio, Pequeno");
            }
        }
    }
}