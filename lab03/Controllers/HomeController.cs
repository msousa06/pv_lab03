using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab03.Models;

namespace lab03.Controllers
{
    public class HomeController : Controller
    {
        public List<Carro> carros = new List<Carro>();

         

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Carros()
        {
            Carro c1 = new Carro
            {
                Codigo = 1,
                Marca = "BMW",
                Modelo = "Serie 3 Diesel",
                NumeroDePassageiros = 5,
                NumeroDePortas = 4,
                EmissoesCO2 = 106,
                TipoDeCaixa = "Manual",
                Comentarios = new List<string> {
                                "2017-10-25 17:45. Carro rápido e confortavel. Carlos",
                                "2017-10-30 12:10. Bom carro e atendimento excelente. JR",
                                "2017-10-30 12:10. TopCAR é mesmo TOP, continuem o bom serviço. Fernanda"
                 }
            };

            Carro c2 = new Carro
            {
                Codigo = 2,
                Marca = "MERCEDES",
                Modelo = "BENZ C220 CDI SW",
                NumeroDePassageiros = 5,
                NumeroDePortas = 4,
                EmissoesCO2 = 128,
                TipoDeCaixa = "Manual",
                Comentarios = new List<string> {
                    "2017-10-15 12:36. Carro que é carro, so mesmo um Mercedes. Filipe",
                    "2017-10-20 15:47. A TopCAR é um mimo, Recomendo. António Faneca",
                    "2017-11-03 09:23. Tinha um pisca avariado. Casimiro"
                 }
            };

            carros.Add(c1);
            carros.Add(c2);

            return View(carros);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
