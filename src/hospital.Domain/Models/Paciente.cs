using hospital.Domain.Entities;
using hospital.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hospital.Domain.Models
{
    public class Paciente : EntityBase
    {
        public Paciente()
        {
            this.DataInternacao = DateTime.Now;
            Ativo = true;
        }
        [ForeignKey("EstadoPaciente")]
        [Display(Name="Estado do Paciente")]
        public Guid? EstadoPacienteId { get; set; }
        public virtual EstadoPaciente? EstadoPaciente { get; set; }
        public String ?Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInternacao { get; set; }
        public String ?Email { get; set; }
        public bool Ativo { get; set; }
        public String ?CPF { get; set; }
        public TipoPaciente TipoPaciente { get; set; }
        public Sexo Sexo{ get; set; }
        public String ?RG{ get; set; }
        public String ?RgOrgao{ get; set; }
        public DateTime RgDataEmissao{ get; set; }

    }
}
