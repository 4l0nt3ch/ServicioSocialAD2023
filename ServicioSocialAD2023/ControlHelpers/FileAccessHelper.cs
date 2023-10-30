using System.IO;
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

        public static string CheckFileExistence(string baseDirectory, CSPrograma prog, string ext)
        {
            string status = string.Empty;
            string fileName = $"{prog.Alumno.Matricula}_" +
                    $"{prog.Alumno.Nombre.ToUpper()}_{prog.Alumno.ApellidoPaterno.ToUpper()}" +
                    $"_{prog.Alumno.ApellidoMaterno.ToUpper()}.{ext}";
            try
            {
                string[] archivos = Directory.GetFiles(baseDirectory, fileName, SearchOption.AllDirectories);

                if (archivos.Length > 0)
                {
                    status = "Liberado";
                }
                else
                {
                    status = "Registrado";
                }
            }
            catch (Exception ex)
            {
                status = "Error";
            }

            return status;
        }

        public static void GetRecordsProcessed(List<CSPrograma> prog, TextBox tBox1, TextBox tBox2, TextBox tBox3, TextBox tBox4, ComboBox cBox)
        {
            int counterFailed = 0;
            int counterSuccessful = 0;
            int counterPending = 0;

            foreach (CSPrograma progRecord in prog)
            {
                string fileExistence = CheckFileExistence(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives"),
                    progRecord, ComboBoxHelper.CBGetFileFormat(cBox));

                switch (fileExistence)
                {
                    case "Liberado":
                        counterSuccessful += 1;
                        break;
                    case "Registrado":
                        counterPending += 1;
                        break;
                    case "Error":
                        counterFailed += 1;
                        break;
                }
            }

            tBox1.Text = prog.Count.ToString();
            tBox2.Text = counterSuccessful.ToString();
            tBox3.Text = counterPending.ToString();
            tBox4.Text = counterFailed.ToString();
        }

        public static void UpdateFileAmmount(TextBox tBox)
        {
            tBox.Text = GetTotalFiles(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives")
                        ).ToString();
        }

        private static int GetTotalFiles(string directory)
        {
            try
            {
                string[] files = Directory.GetFiles(directory,"*",SearchOption.AllDirectories);
                return files.Length;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error al contar archivos: " + e.Message);
                return 0;
            }
        }

        public static string SaveFileToLocation(string documentType, string arrangeType, CSPrograma programa, string fileFormat)
        {

            string directory = string.Empty;

            switch (arrangeType)
            {
                case "Estudiante":
                    directory =  Path.Combine(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}"),
                                $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.{fileFormat}");
                    break;
                case "Carrera":
                    directory = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Alumno.Carrera.Abreviacion}",
                                $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.{fileFormat}"
                        );
                    break;
                case "Dependencia Educativa":
                    directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Dependencia.DENombre}",
                                $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.{fileFormat}"
                        );
                    break;
                case "Dependencia Privada":
                    directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Empresa.RazonSocial}",
                                $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.{fileFormat}"
                        );
                    break;
                case "Responsable":
                    directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Responsable.Carrera.Abreviacion} {programa.Responsable.Nombre} {programa.Responsable.ApellidoPaterno} {programa.Responsable.ApellidoMaterno}",
                                $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.{fileFormat}");
                    break;
                case "Coordinador":
                    directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Coordinador.Carrera.Abreviacion} {programa.Coordinador.Nombre} {programa.Coordinador.ApellidoPaterno} {programa.Coordinador.ApellidoMaterno}",
                                $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.{fileFormat}");
                    break;
                case "Periodo":
                    directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType,
                                $"{programa.Periodo.Descripcion}",
                                $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.{fileFormat}");
                    break;
                case "default":
                    directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType,
                                $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.{fileFormat}");
                    break;
            }

            if (!Directory.Exists(Path.GetDirectoryName(directory))) {
                Directory.CreateDirectory(Path.GetDirectoryName(directory));
            }

            return directory;
        }

        public static void RearrangeFileToOtherLocation(string[] fileSource, string documentType, string arrangeType, CSPrograma programa)
        {
            foreach (string file in fileSource)
            {
                if (File.Exists(file))
                {
                    switch (arrangeType)
                    {
                        case "Estudiante":
                            MoveFileProcedure(
                                file,
                                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Alumno.Matricula}_{programa.Alumno.Nombre}_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}"),
                                Path.GetFileName(file));
                            break;
                        case "Carrera":
                            MoveFileProcedure(
                                file,
                                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Alumno.Carrera.Abreviacion}"),
                                Path.GetFileName(file));
                            break;
                        case "Dependencia Educativa":
                            MoveFileProcedure(
                                file,
                                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Dependencia.DENombre}"),
                                Path.GetFileName(file));
                            break;
                        case "Dependencia Privada":
                            MoveFileProcedure(
                                file,
                                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Empresa.RazonSocial}"),
                                Path.GetFileName(file));
                            break;
                        case "Responsable":
                            MoveFileProcedure(
                                file,
                                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Responsable.Carrera.Abreviacion} {programa.Responsable.Nombre} {programa.Responsable.ApellidoPaterno} {programa.Responsable.ApellidoMaterno}"),
                                Path.GetFileName(file));
                            break;
                        case "Coordinador":
                            MoveFileProcedure(
                                file,
                                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType
                                , $"{programa.Coordinador.Carrera.Abreviacion} {programa.Coordinador.Nombre} {programa.Coordinador.ApellidoPaterno} {programa.Coordinador.ApellidoMaterno}"),
                                Path.GetFileName(file));
                            break;
                        case "Periodo":
                            MoveFileProcedure(
                                file,
                                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType,
                                $"{programa.Periodo.Descripcion}"),
                                Path.GetFileName(file)
                                );
                            break;
                        case "default":
                            MoveFileProcedure(
                                file,
                                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", documentType),
                                Path.GetFileName(file)
                                );
                            break;
                    }
                }
            }
            
        } 

        public static void MoveFileProcedure(string oldFilename, string newFilePath, string fileName)
        {
            try
            {

                string newFilename = Path.Combine(newFilePath, fileName);

                if (!Directory.Exists(newFilePath))
                {
                    Directory.CreateDirectory(newFilePath);
                }

                if (!File.Exists(newFilename)) {
                    File.Copy(oldFilename, newFilename);
                }
               
                if (File.Exists(newFilename))
                {
                    if (string.Equals(oldFilename, newFilename, StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }
                    else
                    {
                        File.Delete(oldFilename);

                        if (Directory.GetFiles(Path.GetDirectoryName(oldFilename)).ToArray().Length == 0)
                        {
                            Directory.Delete(Path.GetDirectoryName(oldFilename));
                        }
                    }   
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Filename not copied: {fileName} because exception {ex.Message}");
            }
        }
    }
}
