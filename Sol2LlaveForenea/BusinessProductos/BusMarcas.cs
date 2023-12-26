using DataProductos;
using EntityProductos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProductos
{
    public class BusMarcas
    {
        DatMarcas dat = new DatMarcas();

        public List<EntMarcas> Obtener()
        {
            return dat.Obtener();
        }
    }
}
