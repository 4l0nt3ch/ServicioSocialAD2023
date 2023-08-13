using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Roles
{
    public class CSAlumno : CSPersona
    {
        public string Matricula { get; set; }
        public string Estatus { get; set; }
        public CSAlumno() : base() { }

        public CSAlumno(string id,string nombre, string apellidoPaterno, string apellidoMaterno,
            string emailUANL, string emailPersonal, string telefono, string nivelAcademico,
            CSCarrera carrera, string estatus, string matricula) 
            : base(id,nombre,apellidoPaterno,apellidoMaterno,
                  emailUANL,emailPersonal,telefono,nivelAcademico,
                  carrera)
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
            this.Estatus = estatus;
            Matricula = matricula;
        }
    }
}
