using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Entity;

namespace Presentacion.Controllers
{
    public class HomeController : Controller
    {
        DirectorBL directorBL = new DirectorBL();
        PeliculaBL peliculaBL = new PeliculaBL();

        [HttpGet]
        public ActionResult Index()
        {            
            List<Director> directores = new List<Director>();
            directores = directorBL.listarDirectores();        
            return View(directores);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Director director)
        {
            directorBL.crearDirector(director);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Director director = new Director();
            director = directorBL.findById(id);
            return View(director);
        }

        [HttpPost]
        public ActionResult Update(Director director)
        {
            directorBL.actualizarDirector(director);
            return RedirectToAction("Index");            
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            directorBL.eliminarDirector(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult VerPeliculasPorDirector(int id)
        {
            ViewBag.director = directorBL.findById(id).NombreCompleto;
            ViewBag.idDirector = directorBL.findById(id).IdDirector;

            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas = peliculaBL.listarPeliculasPorDirector(id);

            return View(peliculas);
        }

        [HttpGet]
        public ActionResult CreatePelicula(int id)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.IdDirector = id;
            return View(pelicula);
        }

        [HttpPost]
        public ActionResult CreatePelicula(Pelicula pelicula)
        {
            peliculaBL.crearPelicula(pelicula);
            return RedirectToAction("VerPeliculasPorDirector/" + pelicula.IdDirector);
        }

        [HttpGet]
        public ActionResult DeletePelicula(int id)
        {
            int idDirector = peliculaBL.findById(id).IdDirector;
            peliculaBL.eliminarPelicula(id);
            return RedirectToAction("VerPeliculasPorDirector/" + idDirector);
        }

        [HttpGet]
        public ActionResult UpdatePelicula(int id)
        {
            Pelicula pelicula = new Pelicula();
            pelicula = peliculaBL.findById(id);
            return View(pelicula);
        }

        [HttpPost]
        public ActionResult UpdatePelicula(Pelicula pelicula)
        {
            peliculaBL.actualizarPelicula(pelicula);
            return RedirectToAction("VerPeliculasPorDirector/" + pelicula.IdDirector);
        }
    }
}