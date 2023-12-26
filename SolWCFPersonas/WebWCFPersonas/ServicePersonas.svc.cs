using DataBusinessPersonas;
using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebWCFPersonas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicePersonas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicePersonas.svc o ServicePersonas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicePersonas : IServicePersonas
    {
        public List<EntPersonas> Obtener()
        {
            DBPersonas datos = new DBPersonas();
            List<EntPersonas> ls = datos.Obtener();
            return ls;
        }

        public EntPersonas ObtenerPorId(int id)
        {
            DBPersonas datos = new DBPersonas();
            EntPersonas personas = new EntPersonas();
            return personas;
        }

        public void Agregar (EntPersonas p)
        {
            DBPersonas datos = new DBPersonas();
            datos.Agregar(p);
        }
    }
}
