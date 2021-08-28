using System.ComponentModel.DataAnnotations;

namespace TesteMazzaFC.Api.Model
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Descricao { get; set; }
    }
}
