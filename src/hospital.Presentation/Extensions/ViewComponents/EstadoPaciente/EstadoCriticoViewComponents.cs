using hospital.DataAcessLayer.ORM;
using Microsoft.AspNetCore.Mvc;
using mvc.ViewComponents.Helpers;

namespace mvc.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name = "EstadoCritico")]
    public class EstadoCriticoViewComponents : ViewComponent
    {
        private readonly HospitalDbContext _context;
        public EstadoCriticoViewComponents(HospitalDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalGeral = Util.TotalRegistro(_context);
            decimal estadoTotal = Util.GetNumeroRegistroEstado(_context, "Crítico");
            decimal progress =0;
            if (totalGeral != 0)
            {
                progress = (estadoTotal/ totalGeral) * 100;
            } 
            var porcentagem = progress.ToString("F1");

            var model = new ContadorEstadoPaciente();
            model.Titulo = "Paciente em Estado de Critico";
            model.Parcial = (int)estadoTotal;
            model.Percentual = porcentagem;
            model.ClassContainer = "panel panel-danger tile panelClose panelRefresh";
            model.IconeLarge = "l-basic-life-buoy";
            model.IconeSmall = "fa fa-arrow-circle-o-down s20 mr5 pull-left";
            model.Progress = progress;

            return View(model);
        }
    }
}
