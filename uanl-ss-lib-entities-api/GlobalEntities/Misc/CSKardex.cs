using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Misc.Types;
using uanl_ss_lib_entities_api.GlobalEntities.Roles;

namespace uanl_ss_lib_entities_api.GlobalEntities.Misc
{
    public class CSKardex : CSAlumno
    {
        public int Semestre { get; set; }
        public int Creditos { get; set; }
        public CSPlan Plan { get; set; }
        public CSTipoMateria[] Materias { get; set; }

        public CSKardex() : base() { }

        public CSKardex(string id,string nombre, string apellidoPaterno, string apellidoMaterno,
            string emailUANL, string emailPersonal, string telefono, string nivelAcademico,
            CSCarrera carrera, string estatus, string matricula, int semestre, int creditos, 
            CSPlan plan, CSTipoMateria[] materias) 
            : base(id, nombre, apellidoPaterno, apellidoMaterno, 
                emailUANL, emailPersonal, telefono, nivelAcademico, carrera, estatus, matricula)
        {
            ID = id;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            EmailUANL = emailUANL;
            EmailPersonal = emailPersonal;
            Telefono = telefono;
            NivelAcademico = nivelAcademico;
            Carrera = carrera;
            Estatus = estatus;
            Matricula = matricula;
            Semestre = semestre;
            Creditos = creditos;
            Plan = plan;
            Materias = materias;
        }
    }
}
