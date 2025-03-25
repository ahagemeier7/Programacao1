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
                retorno = "O dia é segunda feira";
            }
            else if (x == 2)
            {
                retorno = "O dia é Terça feira";
            }
            else if (x == 3)
            {
                retorno = "O dia é Quarta feira";
            }
            else if (x == 4)
            {
                retorno = "O dia é Quinta feira";
            }
            else if (x == 5) {
                retorno = "O dia é Sexta Feira";
            }
            else if (x == 6){
                retorno = "O dia é Sábado";
            }
            else if (x == 7)
            {
                retorno = "O dia é Domingo";
            }
            else
            {
                retorno = "Dia da semana não existe";
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
