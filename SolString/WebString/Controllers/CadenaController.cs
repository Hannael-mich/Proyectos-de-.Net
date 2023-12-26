using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebString.Models;
namespace WebString.Controllers
{

    public class CadenaController : Controller
    {
        // GET: Cadena
        public static string global = "";
        public static string global1 = "";
        public static string global2 = "";
        public ActionResult Practica(String areaText)
        {
            return View();
        }

        public ActionResult Practica1(String areaText)
        {
            Logica objLogica = new Logica(); ;
            int cadena = objLogica.Cadena(areaText);
            global = global + areaText;
            global1 = areaText;
            TempData["Ejercicio 1"] = $"{areaText} tiene {cadena} caracteres ";
            return View("Practica");
        }

        public ActionResult Practica2(String areaText)
        {
            Logica objLogica1 = new Logica(); ;
            string cadena = objLogica1.Cadena1(areaText);
            global += areaText;
            global2 = areaText;
            TempData["Ejercicio 2"] = $"{cadena}";
            return View("Practica");
        }
        public ActionResult Practica3(String areaText)
        {
            Logica objLogica2 = new Logica(); ;
            string cadena = objLogica2.Cadena2(areaText);
            global += areaText;
            TempData["Ejercicio 3"] = $"{cadena}";
            return View("Practica");
        }

        public ActionResult Practica4()
        {
            TempData["Ejercicio 4"] = $"{global}";
            global = "";
            return View("Practica");

        }

        public ActionResult Practica5()
        {
            Logica ObjLogica5 = new Logica();
            string palabra = ObjLogica5.Verificar(global1, global2);
            TempData["Ejercicio 5"] = $"{palabra}, {global1}, {global2}";
            return View("Practica");
        }
        public ActionResult Practica6(string areaText)
        {
            Logica ObjLogica6 = new Logica();
            string cadenaFinal = ObjLogica6.quitar(areaText);
            TempData["Ejercicio 6"] = $"{cadenaFinal}";
            return View("Practica");

        }

        public ActionResult Practica7(string areaText)
        {
            Logica ObjLogica7 = new Logica();
            string cadenaFinal = ObjLogica7.quitar1(areaText);
            TempData["Ejercicio 7"] = $"{cadenaFinal}";
            return View("Practica");

        }

        public ActionResult Practica8(string areaText)
        {
            Logica ObjLogica8 = new Logica();
            string cadenaFinal = ObjLogica8.quitar2(areaText);
            TempData["Ejercicio 8"] = $"{cadenaFinal}";
            return View("Practica");
        }

        public ActionResult Practica9(string areaText)
        {
            Logica ObjLogica9 = new Logica();
            string cadenaFinal = ObjLogica9.veri(areaText);
            TempData["Ejercicio 9"] = $"El enunciado {areaText} {cadenaFinal} empieza con la palabra Ti";
            return View("Practica");
        }

        public ActionResult Practica10(string areaText)
        {
            Logica ObjLogica10 = new Logica();
            string cadenaFinal = ObjLogica10.rellenar(areaText);
            TempData["Ejercicio 10"] = $"valor caja de texto= {cadenaFinal}";
            return View("Practica");
        }

        public ActionResult Practica11(string areaText)
        {
            Logica ObjLogica11 = new Logica();
            string cadenaFinal = ObjLogica11.frase(areaText);
            TempData["Ejercicio 11"] = $" {cadenaFinal}";
            return View("Practica");
        }

        public ActionResult Practica12(string areaText)
        {
            Logica ObjLogica12 = new Logica();
            string cadenaFinal = ObjLogica12.Alreves(areaText);
            TempData["Ejercicio 12"] = $" {cadenaFinal}";
            return View("Practica");
        }

        public ActionResult Practica13(string areaText)
        {
            Logica ObjLogica13 = new Logica();
            int vocales = ObjLogica13.contadorVocales(areaText);
            TempData["Ejercicio 13"] = $" {vocales}";
            return View("Practica");
        }
    }

}