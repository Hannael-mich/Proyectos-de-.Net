using BusinessPalabras;
using DataPalabras.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPalabras.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Menu");
        }
        public ActionResult IntroducirA() {
            return View("AgregaA");
        }
        public ActionResult BuscarA(string palabrasA)
        {
            BusPalabras pala = new BusPalabras();
            palabras palabraA = new palabras();
            try
            {
                 pala.BuscarA(palabrasA);
            }
            catch (Exception)
            {

                throw;
            }
            return View("Menu");
        }


        public ActionResult Salida()
        {
            return View("Salida");
        }
    }
}