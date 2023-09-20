using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies.Types;
using uanl_ss_lib_entities_api.GlobalEntities.Misc;
using uanl_ss_lib_entities_api.GlobalEntities.Roles;

namespace uanl_ss_lib_entities_api.GlobalEntities.Dependencies
{
    public class CSPrograma
    {
        public string ID { get; set; }
        public CSEmpresa Empresa { get; set; }
        public CSDepEducativa Dependencia { get; set; }
        public CSDepartamento Departamento { get; set; }
        public CSTipoPrograma TipoPrograma { get; set; }
        public string Descripcion { get; set; }
        public CSComunidad Comunidad { get; set; }
        public CSResponsable Responsable { get; set; }
        public CSCoordinador Coordinador { get; set; }
        public CSAlumno Alumno { get; set; }
        public CSTurno Turno { get; set; }
        public CSActividad CSActividad { get; set; }
        public CSPeriodo Periodo { get; set; }

        public CSPrograma () {}
        public CSPrograma(string id, CSEmpresa empresa, CSDepEducativa dependencia, CSDepartamento departamento, string descripcion,
            CSComunidad comunidad, CSResponsable responsable, CSCoordinador coordinador, 
            CSAlumno alumno, CSTurno turno, CSActividad cSActividad, CSPeriodo periodo)
        {
            ID = id;
            Empresa = empresa;
            Dependencia = dependencia;
            Departamento = departamento;
            Descripcion = descripcion;
            Comunidad = comunidad;
            Responsable = responsable;
            Coordinador = coordinador;
            Alumno = alumno;
            Turno = turno;
            CSActividad = cSActividad;
            Periodo = periodo;
        }
    }
}
