using System.ComponentModel.DataAnnotations;

namespace shop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres ")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no minimo 60 caracteres ")]

        public string? Title { get; set; }
    }
}