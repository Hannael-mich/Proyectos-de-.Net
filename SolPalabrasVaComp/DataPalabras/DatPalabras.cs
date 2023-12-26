using DataPalabras.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPalabras
{
    public class DatPalabras
    {
        Generacion23Entities db = new Generacion23Entities();

        public List<palabras> Obtener()
        {
            List<palabras> ls = db.palabras.ToList();
            db.Dispose();
            return ls;
        }
    }
}
