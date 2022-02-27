using hospital.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace mvc.ViewModels
{
    public class CarrinhoViewModel
    {
        public IList<Produto> ?Produtos { get; set; }
        [Required]
        [Range(0, 8000, ErrorMessage = "Field {0} must contain between {1} e {2} ")]
        public decimal TotalCarrinho { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "Field {0} must contain between {2} e {1} character  ", MinimumLength = 1)]
        public String ?Mensagem { get; set; }

    }
}
