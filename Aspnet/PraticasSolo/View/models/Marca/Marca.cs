using System.ComponentModel.DataAnnotations;

namespace View.models
{
    public class Marca
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome da marca é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome da marca não pode exceder 100 caracteres")]
        public string Nome { get; set; } = null!;
    }
}