using hospital.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace hospital.Domain.Models
{
    public class EstadoPaciente : EntityBase
    {
        [Display(Name="Description")]
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(maximumLength: 20, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String Descricao { get; set; }

    }
}
