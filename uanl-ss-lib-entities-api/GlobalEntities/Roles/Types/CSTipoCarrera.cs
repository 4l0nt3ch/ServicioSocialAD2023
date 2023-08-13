using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Roles.Types
{
    public class CSTipoCarrera
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public CSTipoCarrera(int iD, string nombre)
        {
            ID = iD;
            Nombre = nombre;
        }

        public CSTipoCarrera() { }
    }
}
