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
            return View();
        }
    }
}