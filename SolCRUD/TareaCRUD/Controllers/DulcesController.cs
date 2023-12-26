using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TareaCRUD.Controllers
{
    public class DulcesController : Controller
    {
        // GET: Dulces
        public ActionResult Index()
        {
            return View("Vista");
        }
    }
}