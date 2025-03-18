using System.Diagnostics;
using Cheque.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cheque.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        //[HttpPost]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public string Tranformation(int number) 
        {
            Numero array = new();
            int valorTeste = 1524;
            string extenso = "";

            if(valorTeste > 1000)
            {
                extenso += array.unidades[valorTeste/1000] + "mil";
                valorTeste = valorTeste % 1000;
                if (valorTeste > 0) extenso += " e ";
            }

            if (valorTeste > 100) {
                extenso += array.centenas[valorTeste / 100];
                valorTeste = valorTeste % 100;
                if (valorTeste > 0) extenso += " e ";
            }

            if(valorTeste > 20)
            {
                extenso += array.dezenas[valorTeste / 10];
                valorTeste = valorTeste % 10;
                if (valorTeste > 0) extenso += " e ";
            }

            if (valorTeste >= 10 && valorTeste <= 19)
            {
                extenso += array.especiais[valorTeste - 10];
                valorTeste = 0;
            }

            if (valorTeste > 0)
            {
                extenso += array.unidades[valorTeste];
            }

            if(valorTeste == 1000) extenso += array.milhares[1];

            return extenso;
        }
    }
}
