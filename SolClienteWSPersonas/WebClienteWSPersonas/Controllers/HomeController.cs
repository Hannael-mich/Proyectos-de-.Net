using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClienteWSPersonas.ServiceReferenciaPersona;

namespace WebClienteWSPersonas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using(WSPersonasSoapClient ws = new WSPersonasSoapClient())
            {
                List<EntPersonas> lista = new List<EntPersonas>();
                lista = ws.Obtener().ToList();
                return View(lista);
            }
        }

        [HttpGet]
        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EntPersonas p) 
        {
            using (WSPersonasSoapClient ws = new WSPersonasSoapClient())
            {
                ws.Agregar(p);
                TempData["mensaje"] = "Se agrego correctamente a " + p.Nombre;
                return View("Index", ws.Obtener().ToList());
            }
        }

        [HttpGet]
        /*public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(EntPersonas p)
        {
            using (WSPersonasSoapClient ws = new WSPersonasSoapClient())
            {
                ws.Agregar(p);
                TempData["mensaje"] = "Se agrego correctamente a " + p.Nombre;
                return View("Index", ws.Obtener().ToList());
            }
        }*/
    }
}