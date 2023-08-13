using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies.Types;

namespace uanl_ss_lib_entities_api.GlobalEntities.Dependencies
{
    public class CSActividad
    {
        public string ID { get; set; }
        public string NombreActividad { get; set; }
        public CSTipoAE TipoActividad { get; set; }

        public CSActividad() { }

        public CSActividad(string id, string nombreActividad, CSTipoAE tipoActividad)
        {
            ID = id;
            NombreActividad = nombreActividad;
            TipoActividad = tipoActividad;
        }
    }
}
