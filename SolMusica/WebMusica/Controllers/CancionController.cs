using System;
using System.Collections.Generic;
using WebMusica.Datos;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMusica.Models;

namespace WebMusica.Controllers
{
    public class CancionController : Controller
    {
        // GET: Cancion
        public ActionResult Index()
        {
            //obtengo el modelo de la vista que es una lista de empleados
            List<E_Cancion> lista = new List<E_Cancion>();
            try
            {
                D_Cancion datos = new D_Cancion();
                lista = datos.ObtenerTodos();
                //datos.AbrirConexion();
                //TempData["mensaje"] = "Conexion exitosa";
                //return View("Consulta");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return View("Consulta", lista);
        }

        public ActionResult IrAgregar() 
        {
            return View("Agregar");
        }

        public ActionResult Agregar (E_Cancion cancion)
        {
            try
            {
                D_Cancion datos = new D_Cancion();
                datos.Agregar(cancion);
                TempData["mensaje"] = $"La cancion {cancion.Titulo} fue agregado correctamente";
                /*bool existe = datos.ExisteNumeroEmpleado(empleado.NumeroEmpleado);
                if (existe == true)
                {
                    TempData["error"] = $"El numero de empleado {empleado.NumeroEmpleado} ya existe en la base de datos";
                }
                else
                {
                    datos.Agregar(empleado);
                    TempData["mensaje"] = $"El empleado {empleado.Nombre} fue agregado correctamente";
                }

                return RedirectToAction("Index");*/
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult Eliminar(int idCancion)
        {
            try
            {
                D_Cancion datos = new D_Cancion();
                datos.Eliminar(idCancion);
                TempData["mensaje"] = $"Se elimino correctamente la cancion con id {idCancion}";
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return RedirectToAction("Index");
        }

        public ActionResult ObtenerParaEditar(int idCancion)
        {
            try
            {
                D_Cancion datos = new D_Cancion();

                E_Cancion cancion = datos.obtenerCancionPorId(idCancion);
                return View("Editar", cancion);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult Editar(E_Cancion cancion)
        {
            try
            {
                D_Cancion datos = new D_Cancion();
                datos.Editar(cancion);
                TempData["mensaje"] = $"Se edito correctamente el empleado con el id {cancion.idCancion}";
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;

            }
            return RedirectToAction("Index");
        }
    }
}