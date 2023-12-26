using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonas
{
    public class EntPersonas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaAlta { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        private string nombreCompleto;
        public string NombreCompleto
        {
            get
            {
                nombreCompleto = $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}";
                return nombreCompleto;
            }
        }
    }
}
