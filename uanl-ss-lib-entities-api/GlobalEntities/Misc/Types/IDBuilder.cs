using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Misc.Types
{
    public class IDBuilder
    {
        public static string RetornarIDAlumno(int id) {
            return "AL" + id;
        }

        public static string RetornarIDCoordinador(int id) {
            return "COR" + id;        
        }

        public static string RetornarIDResponsable(int id) {
            return "RES" + id;
        }

        public static string RetornarIDPrograma(int id) {
            return "PRG" + id;
        }

        public static string RetornarTipoEmpresa(int id) {
            return "TYPE" + id;
        }

        public static string RetornarTipoAE(int id)
        {
            return "TYPA" + id;
        }

        public static string RetornarIDEmpresa(int id)
        {
            return "EMP" + id;
        }

        public static string RetornarIDDepartamento(int id) {
            return "DEP" + id;
        }

        public static string RetornarIDPeriodo(int id)
        {
            return "PER" + id;
        }
    }
}
