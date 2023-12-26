using DataPalabras;
using DataPalabras.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessPalabras
{
    public class BusPalabras
    {
        DatPalabras dat = new DatPalabras();
        public List<palabras> Obtener()
        {
            return dat.Obtener();
        }
    }
}
