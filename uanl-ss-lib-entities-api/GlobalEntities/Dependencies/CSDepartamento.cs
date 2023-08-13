using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies.Types;

namespace uanl_ss_lib_entities_api.GlobalEntities.Dependencies
{
    public class CSDepartamento
    {
        public string ID { get; set; }  
        public string Departamento { get; set; }
        public CSTipoDepartamento TipoDepartamento { get; set; }
        public CSDepartamento() { }
        public CSDepartamento(string id, string departamento, CSTipoDepartamento tipoDepartamento)
        {
            ID = id;
            Departamento = departamento;
            TipoDepartamento = tipoDepartamento;
        }
    }
}
