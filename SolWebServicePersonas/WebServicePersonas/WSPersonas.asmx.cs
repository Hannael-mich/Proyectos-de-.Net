using BusinessPersonas;
using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicePersonas
{
    /// <summary>
    /// Descripción breve de WSPersonas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSPersonas : System.Web.Services.WebService
    {
        BusPersonas bus = new BusPersonas();
        [WebMethod]
        public List<EntPersonas> Obtener()
        {
            List<EntPersonas> ls = new List<EntPersonas>();
            ls = bus.Obtener();
            return ls;
        }

        [WebMethod]
        public EntPersonas ObtenerPorId(int id)
        {
            EntPersonas persona = new EntPersonas();//Codigo de Oscar que no puede ejecutar por falta de 
            persona = bus.ObtenerPorId(id);              //funcion en la capa de negocios.
            return persona;
        }

        [WebMethod]
        public void Agregar(EntPersonas p) 
        {
            bus.Agregar(p);
        }

        [WebMethod]
        public void Editar(EntPersonas p)
        {
            bus.Editar(p);
        }

        [WebMethod]
        public void Borrar(EntPersonas p)
        {
            bus.Borrar(p);
        }
    }
}
