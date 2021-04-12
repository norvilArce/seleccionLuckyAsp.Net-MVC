using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pelicula
    {
        private int mIdPelicula;
        public int IdPelicula
        {
            get { return mIdPelicula; }
            set { mIdPelicula = value; }
        }
        private int mIdDirector;
        public int IdDirector
        {
            get { return mIdDirector; }
            set { mIdDirector = value; }
        }
        private String mNombre;        
        public String Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }
        private String mGenero;
        public String Genero
        {
            get { return mGenero; }
            set { mGenero = value; }
        }
        private String mSinopsis;
        public String Sinopsis
        {
            get { return mSinopsis; }
            set { mSinopsis = value; }
        }
        private DateTime mFchEstreno;
        public DateTime FchEstreno
        {
            get { return mFchEstreno; }
            set { mFchEstreno = value; }
        }
    }
}
