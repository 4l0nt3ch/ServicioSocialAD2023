using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Dependencies.Types
{
    public class CSTipoEmpresa
    {
        public string ID { get; set; }
        public string NombreTipo { get; set; }

        public CSTipoEmpresa() { }

        public CSTipoEmpresa(string iD, string nombreTipo)
        {
            ID = iD;
            NombreTipo = nombreTipo;
        }
    }
}
