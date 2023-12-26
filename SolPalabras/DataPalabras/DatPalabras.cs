using DataPalabras.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataPalabras
{
    public class DatPalabras
    {
        //Generacion23Entities db = new Generacion23Entities();
        public void BuscarA(string palabrasA) 
        {
            string[] palabras = palabrasA.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var palabrasConVa = palabras.Where(palabra => palabra.Contains("va")).ToArray();
            var palabrasConBa = palabras.Where(palabra => palabra.Contains("ba")).ToArray();
            
            string palabrasConVaYBa="";

            foreach (var simbolo in palabrasConVa)
            {
                palabrasConVaYBa += simbolo+" ";
            }

            foreach (var simbolo in palabrasConBa)
            {
                palabrasConVaYBa += simbolo + " ";
            }

            palabrasConVaYBa += "dgd";

        }

        

    }
}
