using BusiPersonas;
using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebJsonAjaxPersonas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        BPersonas bus = new BPersonas();
        EPersonas ent = new EPersonas();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Obtener()
        {
            try
            {
                List<EPersonas> lsPersonas = bus.Obtener();

                return Json(new { mensaje = "ok", ls = lsPersonas },JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message });
            }
        }
    }
}