using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Misc.Types
{
    public class CSTipoMateria
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public int Semestre { get; set; }
        public string[] Oportunidades { get; set; }
        public int indiceOportunidad { get; set; }
        public string Laboratorio { get; set; }
        public CSTipoMateria() { }
        public CSTipoMateria(string id, string nombre, int creditos, int semestre, string[] oportunidades, int indiceOportunidad
            ,string laboratorio)
        {
            ID = id;
            Nombre = nombre;
            Creditos = creditos;
            Semestre = semestre;
            Oportunidades = oportunidades;
            this.indiceOportunidad = indiceOportunidad;
            Laboratorio = laboratorio;
        }
    }
}
