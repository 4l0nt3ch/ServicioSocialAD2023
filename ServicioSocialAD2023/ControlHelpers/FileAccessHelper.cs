using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using uanl_ss_lib_xml_local_api;
using uanl_ss_main_ui.Entities;

namespace uanl_ss_main_ui.ControlHelpers
{
    public class FileAccessHelper
    {
        public static string CreateFileDirectory(string path)
        {
            if (!File.Exists(path))
            {
                XmlCrud<RepoConfiguration> repoConfig = new XmlCrud<RepoConfiguration>(path);

                repoConfig.CreateFile();

                return path;
            }
            else
            {
                return path;
            }
        }

        
        public static string DefineExportingRoute(string txtCmb, string Template, CSPrograma programa, string Formato) {
            
            string studentDir = $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}";
            //string exportRoute = string.Empty;
            string exportRoute;

            switch (txtCmb)
            {
                case "Estudiante":

                    exportRoute = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"UANL Servicio Social\"Archives\"AD2023\"{Template}\"{studentDir}\"{studentDir}.{Formato}");

                    break;

                case "Carrera":

                    string CarreraDir = $"{programa.Alumno.Carrera}";
                    exportRoute = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"UANL Servicio Social\"Archives\"AD2023\"{Template}\"{CarreraDir}\"{studentDir}\"{studentDir}.{Formato}");

                    break;

                case "DependenciaP":

                    string DependenciaPDir = $"{programa.Dependencia}";
                    exportRoute = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"UANL Servicio Social\"Archives\"AD2023\"{Template}\"{DependenciaPDir}\"{studentDir}\"{studentDir}.{Formato}");

                    break;

                case "Responsable":

                    string ResponsableDir = $"{programa.Responsable}";
                    exportRoute = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"UANL Servicio Social\"Archives\"AD2023\"{Template}\"{ResponsableDir}\"{studentDir}\"{studentDir}.{Formato}");

                    break;


                default:
                    throw new ArgumentException("no válido");

            }

            return exportRoute;
        }
           
    }
}
