using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Roles
{
    public class CSCoordinador : CSPersona
    {
        public string Estatus { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public byte[] SelloDependencia { get; set; }
        public byte[] FirmaCoordinador { get; set; }

        public CSCoordinador() : base() { }  

        public CSCoordinador(string id, string nombre, string apellidoPaterno, string apellidoMaterno,
            string emailUANL, string emailPersonal, string telefono, string nivelAcademico,
            CSCarrera carrera, string estatus, string usuario, string password, byte[] selloDependencia, byte[] firmaCoordinador)
            : base (id, nombre,apellidoPaterno,apellidoMaterno,emailUANL, emailPersonal,telefono, nivelAcademico, carrera)
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
            Usuario = usuario;
            Password = password;
            SelloDependencia = selloDependencia;
            FirmaCoordinador = firmaCoordinador;
        }
    }
}
