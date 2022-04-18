using Microsoft.AspNetCore.Mvc;
using mvc.ViewComponents.Helpers;

namespace mvc.ViewComponents.CabecalhoModulos
{
    [ViewComponent(Name="Cabecalho")]
    public class CabecalhoViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string titulo, string subtitulo)
        {
            var modulo = new Modulo()
            {
                Titulo = titulo,
                Subtitulo = subtitulo
            };
            return View(modulo);
        }
    }
}
 