using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Roles
{
    public class CSPersona
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string EmailUANL { get; set; }
        public string EmailPersonal { get; set; }
        public string Telefono { get; set; }
        public string NivelAcademico { get; set; }
        public CSCarrera Carrera { get; set; }
        public CSPersona(string id, string nombre, string apellidoPaterno, string apellidoMaterno, 
            string emailUANL, string emailPersonal, string telefono, string nivelAcademico, 
            CSCarrera carrera)
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
        }

        public CSPersona() { }
        


    }
}
