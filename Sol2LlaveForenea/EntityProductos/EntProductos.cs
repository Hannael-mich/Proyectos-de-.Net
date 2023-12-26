using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProductos
{
    public class EntProductos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int MarcaId { get; set; }
        public int DepartamentoId { get; set; }
        public EntDepartamentos EntDepartamentos { get; set;}
        public EntMarcas EntMarcas { get; set; }

    }
}
