using System.ComponentModel;

namespace hospital.Domain.Enums
{
    public enum TipoMovimentoPaciente
    {
        [Description("Entrada de Paciente")]
        Entrada = 1,
        [Description("Saida de Paciente")]
        Saida
    }
}
