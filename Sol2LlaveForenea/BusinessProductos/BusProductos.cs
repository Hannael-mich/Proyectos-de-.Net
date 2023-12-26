using DataProductos;
using EntityProductos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProductos
{
    public class BusProductos
    {
        DatProductos dat = new DatProductos();

        public List<EntProductos> Obtener()
        {
            List<EntProductos> ls = dat.Obtener();
            return ls;
        }

        public EntProductos Obtener(int id)
        {
            EntProductos p = dat.Obtener(id);
            return p;
        }

        public void Agregar(EntProductos p)
        {
            dat.Agregar(p);
        }

        public void Editar (EntProductos p)
        {
            dat.Editar(p);
        }

        public List<EntProductos> BuscarUsuario(string texto)
        {
            List<EntProductos> ls = dat.Buscar(texto);
            return ls;
        }

        public void Borrar(int id)
        {
            dat.Borrar(id);
        }
    }
}
