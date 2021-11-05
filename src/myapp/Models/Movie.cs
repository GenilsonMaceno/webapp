using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myapp.Models
{

    [Table("Tb_Movie")]
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3), Required] // Combinando atribuitos
        public string Title { get; set; }

        // [Display(Name = "Release Date")]
        // Posso usar o DISPLAYFORMAT para especificar um tipo de data
        // ApplyFormatInEditMode: especifica que a formatação também deve ser aplicada quando o valor é exibido em uma caixa de texto para edição.
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(20)]
        public string Genre { get; set; }

        [Range(1,100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(1), Required]
        public string Rating { get; set; }
    }
}