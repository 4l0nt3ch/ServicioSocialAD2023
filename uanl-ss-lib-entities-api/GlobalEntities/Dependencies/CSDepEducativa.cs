using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Dependencies
{
    public class CSDepEducativa
    {
        public string ID { get; set; }
        public string DENombre { get; set; }
        public string DENivelEducativo { get; set; }
        public string DEDireccion { get; set; }
        public string DESiglas { get; set; }

        public CSDepEducativa() { } 

        public CSDepEducativa(string deId, string deNombre, string deNivelEducativo, string direccion, string deSiglas) {
            ID = deId;
            DENombre = deNombre;
            DENivelEducativo = deNivelEducativo;
            DEDireccion = direccion;
            DESiglas = deSiglas;
        }
    }
}
