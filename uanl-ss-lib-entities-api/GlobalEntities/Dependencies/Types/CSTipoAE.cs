using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Dependencies.Types
{
    public class CSTipoAE
    {
        public string ID {  get; set; }
        public string Descripcion { get; set; }

        public CSTipoAE() { }

        public CSTipoAE(string iD, string descripcion)
        {
            ID = iD;
            Descripcion = descripcion;
        }
    }
}
