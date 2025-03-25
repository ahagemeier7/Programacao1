using System.Diagnostics;
using Dias_da_semana.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dias_da_semana.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string getDayofWeek(int x)
        {

            int[] days = [1, 2, 3, 4, 5, 6, 7];
            string retorno = string.Empty;

            if (x == 1)
            {
                retorno = "O dia � segunda feira";
            }
            else if (x == 2)
            {
                retorno = "O dia � Ter�a feira";
            }
            else if (x == 3)
            {
                retorno = "O dia � Quarta feira";
            }
            else if (x == 4)
            {
                retorno = "O dia � Quinta feira";
            }
            else if (x == 5) {
                retorno = "O dia � Sexta Feira";
            }
            else if (x == 6){
                retorno = "O dia � S�bado";
            }
            else if (x == 7)
            {
                retorno = "O dia � Domingo";
            }
            else
            {
                retorno = "Dia da semana n�o existe";
            }

            return retorno;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
