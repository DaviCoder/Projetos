using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avaliacao3.Model
{
    public class Cliente_MD : Base_MD
    {
        [Column("nome")]
        public string Nome { get; set; }
        [Column("porteempresa")]
        [Range(0, 2, ErrorMessage = "O porte da empresa deve estar entre 0 e 2")]
        public PorteEmpresa PorteEmpresa { get; set; }
    }
}
