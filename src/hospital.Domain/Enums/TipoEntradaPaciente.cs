using System.ComponentModel;

namespace hospital.Domain.Enums
{
    public enum TipoEntrada
    {
        [Description("Internação")]
        Internacao = 1,
        [Description("Emergência")]
        Emergencia,
        [Description("Transferência")]
        Transferencia,
        [Description("Ambulatório")]
        Ambulatorio,
        [Description("Sem Prontuário")]
        SemProntuario
    }
}
