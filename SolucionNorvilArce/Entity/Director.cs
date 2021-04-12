using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Director
    {
        private int mIdDirector;
        public int IdDirector
        {
            get { return mIdDirector; }
            set { mIdDirector = value; }
        }
        private String mApellidos;
        public String Apellidos
        {
            get { return mApellidos; }
            set { mApellidos = value; }
        }        
        private String mNombres;
        public String Nombres
        {
            get { return mNombres; }
            set { mNombres = value; }
        }
        private String mNombreCompleto;
        public String NombreCompleto
        {
            get { return mNombreCompleto; }
            set { mNombreCompleto = value; }
        }
        private String mPais;
        public String Pais
        {
            get { return mPais; }
            set { mPais = value; }
        }
        private DateTime mFchNac;
        public DateTime FchNac
        {
            get { return mFchNac; }
            set { mFchNac = value; }
        }
    }
}
