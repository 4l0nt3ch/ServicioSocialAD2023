using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Roles.Types;

namespace uanl_ss_lib_entities_api.GlobalEntities.Roles
{
    public class CSCarrera
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public CSTipoCarrera Tipo { get; set; }
        public string Abreviacion { get; set; }

        public CSCarrera() { }
        public CSCarrera(string nombre, CSTipoCarrera tipo, string abreviacion)
        {
            Nombre = nombre;
            Tipo = tipo;
            Abreviacion = abreviacion;
        }
    }
}
