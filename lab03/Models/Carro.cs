using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab03.Models
{
    public class Carro
    {

        [Key] public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int NumeroDePassageiros { get; set; }
        public int NumeroDePortas { get; set; }
        public int EmissoesCO2 { get; set; }
        public string TipoDeCaixa { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped] public List<string> Comentarios { get; set; }

        public Carro()
        {
            this.Codigo = -1;
            this.Marca = "ND";
            this.Modelo = "ND";
            this.NumeroDePassageiros = -1;
            this.NumeroDePortas = -1;
            this.EmissoesCO2 = -1;
            this.TipoDeCaixa = "ND";
            this.Comentarios = new List<String>();
        }

    }
}
