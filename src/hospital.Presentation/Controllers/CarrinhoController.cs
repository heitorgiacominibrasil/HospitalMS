using hospital.Domain.Entities;
using mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>();
            for (int i = 0; i < 10; i++)
            {
                produtos.Add(new Produto
                {
                    Nome = "Prod-" + i,
                    Estoque = i,
                    Validade = DateTime.Now,
                    Valor = 1.13M * i
                });
                       //Valor =  1.13M * i
            }

            //var Model = new CarrinhoViewModel
            //{
            //    Produtos = produtos,
            //    TotalCarrinho = produtos.Sum(x => x.Valor),
            //    Mensagem = "Obrigado por comprar conosco"
            //};
            var Model = new CarrinhoViewModel();
            Model.Produtos = produtos;
            Model.TotalCarrinho = produtos.Sum(x => x.Valor);
            Model.Mensagem = "Obrigado por comprar conosco";

            //return View(Model);


            return RedirectToAction("Checkout", Model);
        }


        public IActionResult Checkout(CarrinhoViewModel modelcarrinho)
        {
            if (!ModelState.IsValid)
            {
                if (ModelState.ErrorCount > 0)
                {
                    ViewData["semerro"] = "OPS!";
                    ModelState.AddModelError("error", " The Model is invalid");
                }
            }
            else
            {
                ViewData["semerro"] = "Modelo OK!";
            }
            

            return View(modelcarrinho);


        }



    }
}
