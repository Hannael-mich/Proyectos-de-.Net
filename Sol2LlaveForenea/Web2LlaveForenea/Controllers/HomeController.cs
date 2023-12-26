using BusinessProductos;
using EntityProductos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2LlaveForenea.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        BusProductos bus = new BusProductos();
        BusMarcas busM = new BusMarcas();
        BusDepartamentos busD = new BusDepartamentos();
        public ActionResult Index()
        {
            
            try
            {
                List<EntProductos> ls = bus.Obtener();
                return View("Consulta", ls);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View(new List<EntProductos>());
            }
            
        }

        public ActionResult AgregarFormulario()
        {
            try
            {
                //metodo obtener Departamentos
                //metodo obtener Marcas
                List<EntMarcas> lsm = busM.Obtener();
                List<EntDepartamentos> lsd = busD.Obtener();

                ViewBag.Marcaid = new SelectList(lsm, "id", "Nombre");
                ViewBag.Departamentoid = new SelectList(lsd, "id", "Nombre");

                return View();
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult Agregar(EntProductos p)
        {
            try
            {
                bus.Agregar(p);
                TempData["mensaje"] = "Se agrego con exito";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                List<EntMarcas> lsm = busM.Obtener();
                List<EntDepartamentos> lsd = busD.Obtener();

                int id;

                EntProductos producto = new EntProductos();

                id = producto.Id;

                producto = bus.Obtener(id);

                ViewBag.Marcaid = new SelectList(lsm, "id", "Nombre", producto.MarcaId);
                ViewBag.Departamentoid = new SelectList(lsd, "id", "Nombre",producto.DepartamentoId);
                return RedirectToAction("AgregarFormulario");
            }
        }

        public ActionResult BuscarAlgo(string texto)
        {
            try
            {
                List<EntProductos> ls = bus.BuscarUsuario(texto);
                return View("Consulta", ls);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View(new List<EntProductos>());
            }

        }

        public ActionResult EditarFormulario(int id)
        {
            try
            {

                List<EntMarcas> lsm = busM.Obtener();
                List<EntDepartamentos> lsd = busD.Obtener();

                EntProductos producto = new EntProductos();

                producto = bus.Obtener(id);

                ViewBag.Marcaid = new SelectList(lsm, "id", "Nombre", producto.MarcaId);
                ViewBag.Departamentoid = new SelectList(lsd, "id", "Nombre", producto.DepartamentoId);

                return View("Editar", producto);



                
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.StackTrace;
                return RedirectToAction("Consulta");
            }
        }

        public ActionResult Editar(EntProductos producto)
        {
            try
            {
                bus.Editar(producto);

                TempData["mensaje"] = $"Se edito correctamente el empleado con el id {producto.Id}";
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;

            }
            return RedirectToAction("Index");
        }

        public ActionResult Borrar(int id)
        {
            try
            {
                bus.Borrar(id);
                TempData["mensaje"] = $"Se elimino correctamente el Producto con id {id}";
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return RedirectToAction("Index");

        }
    }
}