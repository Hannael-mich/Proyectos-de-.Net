using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WebString.Models
{
    public class Logica
    {
        public int Cadena(string cade) {
            int tamanio = cade.Length; 
            return tamanio;
        }
        public string Cadena1(string cade)
        {
            string newCad = cade.ToLower();
            return newCad;
        }
        public string Cadena2(string cade)
        {
            string newCad = cade.ToUpper();
            return newCad;
        }
        /*public string Concatenar(string cade)
        {
            string newCad = cade.ToUpper();
            return newCad;
        }*/

        public string Verificar(string palabra1, string palabra2)
        {
            string respuesta;
            if (palabra1.Contains(palabra2))
            {
               respuesta = palabra1;
            }
            if (palabra2.Contains(palabra1))
            {
                respuesta = palabra2;
            }
            else
            {
                respuesta = "No existe";
            }
            return respuesta;
        }

        public string quitar(string cadena) {

            string cadenaSinComas = cadena.Replace(",", "");
            string cadenaFinal = cadenaSinComas.Replace("/", "");
            return cadenaFinal;
        }

        public string quitar1(string cadena)
        {

            string cadenaSinComas = cadena.Replace(",", "");
            
            return cadenaSinComas;
        }

        public string quitar2(string cadena)
        {

            string cadenaSinComas = cadena.Replace(" ", "");

            return cadenaSinComas;
        }

        public string veri(string cadena)
        {

            bool comienzaConTi = cadena.StartsWith("Ti", StringComparison.OrdinalIgnoreCase);
            string resultadoMensaje = "";

            if (comienzaConTi)
            {
                resultadoMensaje = "Si";
            }
            else {
                resultadoMensaje = "No";
            }

            return resultadoMensaje;
        }

        public string rellenar(string cadena)
        {
            string cadenaRellenada = cadena.PadLeft(5, '0');
            return cadenaRellenada;
        }

        public string frase(string cadena)
        {
            string[] oracion = cadena.Split(' ');
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            for (int i = 0; i < oracion.Length; i++)
            {
                string palabra = oracion[i];
                if (!string.IsNullOrEmpty(palabra))
                {
                    oracion[i] = ti.ToTitleCase(palabra.ToLower()); // Convertir a formato TitleCase
                }
            }
            string fraseFormateada = string.Join(" ", oracion);

            return fraseFormateada;
        }

        public string Alreves(string cadena)
        {
          
            string textoAlReves = "";

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                textoAlReves +=cadena[i];
            }

            return textoAlReves;
        }

        public int contadorVocales(string cadena)
        {
            cadena = cadena.ToLower();

            int conteo = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                char c = cadena[i];
                bool algo ="aeiouáéíóú".Contains(c);
                if (algo)
                {
                    conteo++;
                }
            }
            return conteo;

        }







    }
}