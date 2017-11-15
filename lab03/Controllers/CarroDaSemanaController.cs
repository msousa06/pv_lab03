using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab03.Models;

namespace lab03.Controllers
{
    public class CarroDaSemanaController : Controller
    {
        public IActionResult Index()
        {
            Carro carro = new Carro {
                Marca = "BMW",
                Modelo = "Serie 3 Diesel",
                NumeroDePassageiros = 5,
                NumeroDePortas = 4,
                EmissoesCO2 = 106, //g/km
                TipoDeCaixa = "Manual",
                Comentarios = new List<string> {
                "2017-10-25 17:45. Carro rápido e confortavel. Carlos",
                "2017-10-30 12:10. Bom carro e atendimento excelente. JR",
                "2017-10-30 12:10. TopCAR é mesmo TOP, continuem o bom trabalho. Luis"
                }
            };
            return View(carro);
        }

        public VirtualFileResult DescarregarVideo()
        {
            return File("~/videos/bmw_video.mp4", "application/mp4", "bmw_video.mp4");
        }
            
        }
    }
