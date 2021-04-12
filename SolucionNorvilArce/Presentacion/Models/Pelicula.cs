using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentacion.Models
{
    public class Pelicula
    {
        public Int16 IdPelicula { get; set; }
        public Int16 IdDirector { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Sinopsis { get; set; }
        public DateTime FchEstreno { get; set; }
    

    }
}