using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using PrimeiraApp.Models;


namespace PrimeiraApp.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {
            //var aluno = new Aluno();
            var aluno = new Aluno();
            {
                Nome = "J",
                Email = "Jeferson",
                EmailConfirmacao = "Jeferson.com",

            };

            if (TryValidateModel(aluno))
            {
                return View(aluno);
            }

            var ms = ModelState;

            var erros = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();

            erros.ForEach(r => Console.WriteLine(r.First().ErrorMessage));
            return View();
        }
    }
}
