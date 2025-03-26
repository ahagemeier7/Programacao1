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
            //int valorTeste = 1524;
            string extenso = "";

            if(number > 1000)
            {
                extenso += array.unidades[number / 1000] + "mil";
                number = number % 1000;
                if (number > 0) extenso += " e ";
            }

            if (number > 100) {
                extenso += array.centenas[number / 100];
                number = number % 100;
                if (number > 0) extenso += " e ";
            }

            if(number > 20)
            {
                extenso += array.dezenas[number / 10];
                number = number % 10;
                if (number > 0) extenso += " e ";
            }

            if (number >= 10 && number <= 19)
            {
                extenso += array.especiais[number - 10];
                number = 0;
            }

            if (number > 0)
            {
                extenso += array.unidades[number];
            }

            if(number == 1000) extenso += array.milhares[1];

            return extenso;
        }
    }
}
