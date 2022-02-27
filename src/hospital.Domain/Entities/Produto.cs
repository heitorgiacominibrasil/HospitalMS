using System.ComponentModel.DataAnnotations;

namespace hospital.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        [Display(Name = "Product its id")]
        public Guid Id { get; set; }

        [Display(Name = "Product its name")]
        [Required(ErrorMessage = "Field {0} is required ")]
        [StringLength(80, ErrorMessage = "Field {0} must contain between {2} e {1} character  ", MinimumLength = 1)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Field {0} is required ")]
        [Range(20, 5000, ErrorMessage = "Field {0} must contain between {1} e {2} ")]
        public decimal Valor { get; set; }

        public int Estoque { get; set; }
        [Display(Name = "Product its Validate", Description = "Select an " +
            "futute date.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date"), 
            DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm }")]
        public DateTime Validade { get; set; }

        public bool TemEmEstoque { get; set; }


    }
}
