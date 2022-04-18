using hospital.DataAcessLayer.ORM;
using Microsoft.EntityFrameworkCore;

namespace mvc.ViewComponents.Helpers
{
    public class Util
    {
        public static int TotalRegistro(HospitalDbContext context)
        {
            return (from paciente in context.Paciente.AsNoTracking()
                    select paciente).Count();
        }

        public static decimal GetNumeroRegistroEstado(HospitalDbContext context, string estado)
        {
            return context.Paciente
                    .AsNoTracking()
                    .Count(x => x.EstadoPaciente.Descricao.Contains(estado));
        }
    }
}
