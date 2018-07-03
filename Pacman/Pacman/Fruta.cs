using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class Fruta
    {
        public string NombreFruta { get; set; }
        public int PuntajeFruta { get; set; }

        public Fruta(string NombreFruta, int Puntaje)
        {
            this.NombreFruta = NombreFruta;
            this.PuntajeFruta = PuntajeFruta;
        }
    }
