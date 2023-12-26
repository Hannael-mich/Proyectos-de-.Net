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
        BusPalabras bus = new BusPalabras();
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                List<palabras> ls = bus.Obtener();
                return View("Menu");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}