using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoWeb.Models;

namespace PrimeiroProjetoWeb.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            var pessoas = new List<PessoaViewModel>();
            pessoas.Add(
                new PessoaViewModel()
                {
                    Nome = "Ana Carolina",
                    Idade = 28,
                    Telefone = "11 2525-2525"
                });
            pessoas.Add(
                new PessoaViewModel()
                {
                    Nome = "Joao da Silva",
                    Idade = 30,
                    Telefone = "11 2525-2525"
                });
            return View();
        }
    }
}
