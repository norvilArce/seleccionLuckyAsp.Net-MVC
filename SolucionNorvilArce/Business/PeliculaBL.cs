using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using Data;

namespace Business
{
    public class PeliculaBL
    {
        PeliculaADO peliculaADO = new PeliculaADO();
        public Boolean crearPelicula(Pelicula pelicula)
        {
            return peliculaADO.crearPelicula(pelicula);
        }
        public List<Pelicula> listarPeliculas()
        {
            return peliculaADO.listarPeliculas();
        }
        public Boolean actualizarPelicula(Pelicula pelicula)
        {
            return peliculaADO.actualizarPeliculas(pelicula);
        }
        public Boolean eliminarPelicula(int id)
        {
            return peliculaADO.eliminarPelicula(id);
        }
        public List<Pelicula> listarPeliculasPorDirector(int id)
        {
            return peliculaADO.listarPeliculasPorDirector(id);
        }

        public Pelicula findById(int id)
        {
            return peliculaADO.findPeliculaById(id);
        }

    }
}
