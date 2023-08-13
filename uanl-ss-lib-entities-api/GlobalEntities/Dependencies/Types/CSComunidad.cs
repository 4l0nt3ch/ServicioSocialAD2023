using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Dependencies.Types
{
    public class CSComunidad
    {
        public string ID { get; set; }
        public string NombreComunidad { get; set; }

        public CSComunidad() { }

        public CSComunidad(string iD, string nombreComunidad)
        {
            ID = iD;
            NombreComunidad = nombreComunidad;
        }
    }
}
