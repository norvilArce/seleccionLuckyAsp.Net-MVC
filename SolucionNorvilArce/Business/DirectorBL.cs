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
    public class DirectorBL
    {
        DirectorADO directorADO = new DirectorADO();
        public Boolean crearDirector(Director director)
        {
            return directorADO.crearDirector(director);
        }
        public List<Director> listarDirectores()
        {
            return directorADO.listarDirectores();
        }
        public Boolean actualizarDirector(Director director)
        {
            return directorADO.actualizarDirector(director);
        }
        public Boolean eliminarDirector(int id)
        {
            return directorADO.eliminarDirector(id);
        }

        public Director findById(int id)
        {
            return directorADO.findDirectorById(id);
        }
    }
}
