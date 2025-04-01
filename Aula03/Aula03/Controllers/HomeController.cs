using System.Diagnostics;
using Aula03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula03.Controllers
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
        public string getIf(int x)
        {
            /*
                Estrutura sint�tica do IF 
                if(Express�o boleana) {
                    Senten�a de c�digo a ser executada caso a condi��o retorne true
                }
                caso o if tenha apenas uma linha de comando a ser executada na condicional n�o � necess�rio {}
            
                if(exppress�o boleana)
                    apenas um comando
             */
            string retorno = string.Empty;
            //int x = 10;

            if(x < 9)
                retorno = "x � maior que 9";

            //x = 8;
            if (x > 9)
                retorno = "x � maior que 9";
            else
                retorno = "x � menor que 9";

            //x = 11;
            if(x == 10)
            {
                retorno = "Ora Ora ";
                retorno += "x � igual a 10";
            }
            else if(x == 9)
            {
                retorno = "hmmmm ";
                retorno += "x � igual a 9";
            }
            else if(x == 8)
            {
                retorno = "Bahh ";
                retorno += "X � igual a 8";
            }
            else
            {
                retorno = "Sei l� que n�mero � o x";
            }

            return retorno;
        }

        [HttpGet]
        public string getSwitch(int x)
        {
            /*
             
             */
            string retorno = string.Empty;
            switch(x)
            {
                case 0:
                    retorno = "x � 0";
                    break;
                case 1:
                    retorno = "x � 1";
                    break;
                case 2:
                    retorno = "x � 2";
                    break;
                case 3:
                    retorno = "x � 3";
                    break;
                default:
                    retorno = "x � algum n�mero n�o previsto";
                    break;
            }

            return retorno;
        }

        [HttpGet]
        public string getFor(int x)
        {
            /*
              o comando de repeti��o for possui a seguinte sintaxe:
              for(<inicializador>;<express�o condicional>;<express�o de repeti��o>)
             {
                
                comandos a serem executados

             }

            inicializador: elemento contador, tradicionalmente utilizado o i de index;
            experss�o condicional: especifica o teste a ser verificado quando o loop estiver executado o numero de itera��es flag;
            express�o de repeti��o: especifica a a��o a ser executada com a variavel contadora.
            geralmente um acumulo ou decrescimo (acumulador);
            
             */

            string retorno = string.Empty;
            for (int i = 0; i < 10; i++) { 
                if(i > 50){
                break;
                }

                if (i % 2 == 0)
                {
                    continue;
                }

                retorno += $"{i}: ";
            }

            return retorno;
        }

        [HttpGet]
        public string GetForeach(string color)
        {
            /*
             O comando foreach � utilizado para iterar uma sequencia de itens em uma cole��o
            e servir como uma op��o simples de repeti��o.
             */
            string[] colors = { "Vermelho","Preto","Azul","Amarelo","Verde","Branco","Azul-Marinho","Rosa","Roxo","Cinza" };

            string retorno = string.Empty;

            if (colors.Contains(char.ToUpper(color[0]) + color.Substring(1))) {
                retorno = "A cor escolhida � valida";
            }
            else
            {
                retorno = "Cor escolhida invalida";
            }

            foreach (string s in colors)
            {
                retorno += $" [{s}]";
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
