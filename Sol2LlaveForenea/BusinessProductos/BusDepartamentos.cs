using DataProductos;
using EntityProductos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProductos
{
    public class BusDepartamentos
    {
        DatDepartamentos dat = new DatDepartamentos();

        public List<EntDepartamentos> Obtener()
        {
            return dat.Obtener();
        }
    }
}
