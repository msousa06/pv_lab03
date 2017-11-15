using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab03.Models
{
    public class Carro
    {

        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int NumeroDePassageiros { get; set; }
        public int NumeroDePortas { get; set; }
        public int EmissoesCO2 { get; set; }
        public string TipoDeCaixa { get; set; }
        public List<string> Comentarios { get; set; }

        public Carro()
        {
            Codigo = -1;
            Marca = "ND";
            Modelo = "ND";
            NumeroDePassageiros = -1;
            NumeroDePortas = -1;
            EmissoesCO2 = -1;
            TipoDeCaixa = "ND";
            Comentarios = new List<String> { };
        }

    }
}
