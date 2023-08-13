using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_office_excel_local_api.MinimalAdapterClass
{
    public class CSMinEstudiante
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }    
        public string EmailUANL { get; set; }
        public string EmailPersonal { get; set; }
        public string Telefono { get; set; }
        public string NivelAcademico { get; set; }
        public string Carrera { get; set; }
        public string CarreaAbrev { get; set; }
        public string SituacionSS { get; set; }

        public CSMinEstudiante() { }
        public CSMinEstudiante(string matricula, string nombre, string aPaterno, string aMaterno, 
            string emailUANL, string emailPersonal, string telefono, string nivelAcademico, string carrera,
            string carreaAbrev, 
            string situacionSS)
        {
            Matricula = matricula;
            Nombre = nombre;
            APaterno = aPaterno;
            AMaterno = aMaterno;
            EmailUANL = emailUANL;
            EmailPersonal = emailPersonal;
            Telefono = telefono;
            NivelAcademico = nivelAcademico;
            Carrera = carrera;
            CarreaAbrev = carreaAbrev;
            SituacionSS = situacionSS;
        }
    }
}
