using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMusica.Models
{
    public class E_Cancion
    {
        public int idCancion { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public string Duracion { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string Genero { get; set; }

    }
}