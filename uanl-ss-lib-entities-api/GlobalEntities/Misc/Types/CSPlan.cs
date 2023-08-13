using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Misc.Types
{
    public class CSPlan
    {
        public string ID { get; set; }
        public string Nombre { get; set; }  
        public CSPlan() { }
        public CSPlan(string iD, string nombre)
        {
            ID = iD;
            Nombre = nombre;
        }
    }
}
