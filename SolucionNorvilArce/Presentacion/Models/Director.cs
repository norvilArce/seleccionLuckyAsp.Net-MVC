using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentacion.Models
{
    public class Director
    {
        public Int16 IdDirector { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string NombreCompleto { get; set; }
        public string Pais { get; set; }
        public DateTime FchNac { get; set; }
    }
}