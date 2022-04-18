using System.ComponentModel;

namespace hospital.Domain.Enums
{
    public enum TipoSaidaPaciente
    {
        [Description("Recebeu Alta")]
        Alta = 1,
        [Description("Tranferido")]
        Transferencia,
        [Description("Saiu à Revelia")]
        ARevelia,
        [Description("Veio a Óbito")]
        Obito,
        Outros
    }
}
