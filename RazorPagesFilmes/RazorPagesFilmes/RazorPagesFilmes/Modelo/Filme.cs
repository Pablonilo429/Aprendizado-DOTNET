using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Modelo
{
    public class Filme
    {
        public int ID { get; set; }

        [Display(Name = "Título")]
        [StringLength(100, MinimumLength = 2)]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento{ get; set; }

       
        [Required(ErrorMessage = "Digite o gênero do filme!")]
        [Display(Name = "Gênero")]
        [StringLength(20, MinimumLength = 2)]
        public string Genero { get; set; } = string.Empty;
         
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco{ get; set; }

        [Display(Name = "Avaliacao")]
        [Range(0, 5)]
        public int Avaliacao { get; set; } = 0;


    }
}
