using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace WebPrueba1.Controllers
{
    public class HomeController : Controller 
    {
        // GET: Home
        /*public ActionResult Index()
        {
            return View("Vista");
        }*/

        public static void CerrarPaginaDesdeServidor()
        {
            // Cierra la ventana actual en el lado del servidor
            System.Web.HttpContext.Current.Response.Write("<script>window.close();</script>");
        }
    }

}