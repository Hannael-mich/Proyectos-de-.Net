using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWCFPersonasCliente.ServiceReferencePersonas;

namespace WebWCFPersonasCliente.Controllers
{
    public class HomeController : Controller
    {
        // GET: Homer
        public ActionResult Index()
        {
            try
            {
                using (ServicePersonasClient servicio = new ServicePersonasClient())
                {
                    List<EntPersonas> ls = servicio.Obtener().ToList();
                    return View(ls);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                List<EntPersonas> ls = new List<EntPersonas>();
                return View(ls);
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create (EntPersonas p)
        {
            try
            {
                using (ServicePersonasClient servicio = new ServicePersonasClient())
                {
                    servicio.Agregar(p);
                    TempData["mensaje"] = "Se agrego correctamente a " + p.Nombre;
                    return View("Index", servicio.Obtener().ToList());
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View();
            }
        }
    }
}