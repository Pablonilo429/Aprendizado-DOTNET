using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o título do filme!")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Insira a data de lançamento do filme!")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Insira o gênero do filme!")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; } = string.Empty;
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "Insira o preço do filme!")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Range(0, 5)]
        [Display(Name = "Pontuação")]
        public int? Pontuacao { get; set; }

    }
}
