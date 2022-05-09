using System.ComponentModel.DataAnnotations.Schema;

namespace Avaliacao3.Model
{
    public class Error_MD : Base_MD
    {
        [Column("message")]
        public string Message { get; set; }

        public override string Propriedades()
        {
            return base.Propriedades() + "Message";
        }
        public override string ToString()
        {
            return $"'{CreatedAt}','{Message}'";
        }

    }
}
