using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Roles;

namespace uanl_ss_lib_entities_api.GlobalEntities.Misc
{
    public class CSAcceso
    {
        public CSPersona Persona { get; set; }
        public Boolean IsAdmin { get; set; }
        public long TimeOut { get; set; }
        public Configuration config { get; set; }
        public CSAcceso(CSPersona persona, bool isAdmin, long timeOut, Configuration config)
        {
            Persona = persona;
            IsAdmin = isAdmin;
            TimeOut = timeOut;
            this.config = config;
        }
        public CSAcceso() { }
    }
}
