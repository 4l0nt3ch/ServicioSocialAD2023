using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Dependencies.Types
{
    public class CSTurno
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }  
        public string HoraInicio { get; set; }
        public string HoraFin { get; set;}

        public CSTurno() { }

        public CSTurno(string iD, string descripcion, string horaInicio, string horaFin)
        {
            ID = iD;
            Descripcion = descripcion;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
    }
}
