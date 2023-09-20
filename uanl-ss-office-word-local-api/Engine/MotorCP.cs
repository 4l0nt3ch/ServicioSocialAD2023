using uanl_ss_lib_office_word_local_api.Service;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using System.Reflection;
using System.Globalization;
using System;

namespace uanl_ss_lib_office_word_local_api.Engine
{
    public class MotorCP
    {
        public WordService service { get; set; }

        public MotorCP() {}

        public void CreateTemplateCI(CSPrograma programa)
        {
            try
            {
                service = new WordService();

                Document doc = service.WdOpenTmplFile("Carta de Inicio V1.docx", "AD2023");

                if (!Directory.Exists(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    $"UANL Servicio Social\\Archives\\AD2023\\CISS\\")
                    )) {
                    Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    $"UANL Servicio Social\\Archives\\AD2023\\CISS\\"));         
                }

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    $"UANL Servicio Social\\Archives\\AD2023\\CISS\\{programa.Alumno.Matricula}_{programa.Alumno.Nombre}" +
                    $"_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.docx");

                service.WdSaveFileAs(filePath);

                service.WdFindReplaceText("=MATRICULA",
                    programa.Alumno.Matricula
                    );

                service.WdFindReplaceText("=NOMBREESTUDIANTE",
                    $"{programa.Alumno.Nombre} {programa.Alumno.ApellidoPaterno} {programa.Alumno.ApellidoMaterno}"
                    );

                service.WdFindReplaceText("=SIGLASCARRERA",
                    $"{programa.Alumno.Carrera.Abreviacion}"
                    );

                DateTime date = programa.Periodo.FechaAceptacion;
                CultureInfo cultInfo = new CultureInfo("es-MX");

                string upperMonth = cultInfo.DateTimeFormat.GetMonthName(date.Month).ToUpper()[0] + cultInfo.DateTimeFormat.GetMonthName(date.Month).Substring(1);
                string formattedMonth = date.ToString("d 'de' ") + upperMonth + date.ToString(" 'del' yyyy", cultInfo);

                service.WdFindReplaceText("=FECHAACEPTACION",
                    formattedMonth);

                service.WdFindReplaceText("=COORDINADOR",
                    $"{programa.Coordinador.Carrera.Abreviacion} {programa.Coordinador.Nombre} {programa.Coordinador.ApellidoPaterno} {programa.Coordinador.ApellidoMaterno}"
                    );

                service.WdFindReplaceText("=DEPENDENCIAEDUCATIVA",
                    $"{programa.Dependencia.DENombre}"
                    );


                service.WdSaveFile();
                service.WdCloseFile();
                service.WdShutdown();

            }
            catch(Exception ex) {
                System.Diagnostics.Debug.WriteLine("Hubo un problema con el documento de Word, omitiendo la generación del documento. ex " + ex.Message + " " + ex.Source + "\n" + ex.StackTrace);

                service.WdCloseFile();
                service.WdShutdown();
            }
        } 

        public void CreateTemplateBP(CSPrograma programa) {
            try
            {
                service = new WordService();

                Document doc = service.WdOpenTmplFile("Boleta de Presentación V1.docx", "ad2023");

                if (!Directory.Exists(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    $"UANL Servicio Social\\Archives\\AD2023\\BPSS\\")
                    ))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    $"UANL Servicio Social\\Archives\\AD2023\\BPSS\\"));
                }

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    $"UANL Servicio Social\\Archives\\AD2023\\BPSS\\{programa.Alumno.Matricula}_{programa.Alumno.Nombre}" +
                    $"_{programa.Alumno.ApellidoPaterno}_{programa.Alumno.ApellidoMaterno}.docx");


                service.WdSaveFileAs(filePath);
                service.WdReplaceTextSingle(doc, "00/00/00, 00:00",
                    $"{programa.Periodo.FechaAceptacion.ToString("dd/MM/yy, HH:mm")}");

                string[] progArray =
                {
                    $"{programa.Alumno.Matricula}",
                    $"{programa.Alumno.Nombre} {programa.Alumno.ApellidoPaterno} {programa.Alumno.ApellidoMaterno}",
                    $"{programa.Dependencia.DENombre}",
                    $"{programa.Alumno.Carrera.Nombre} ({programa.Alumno.Carrera.Nombre.ToUpper()})",
                    $"{programa.Empresa.RazonSocial}",
                    $"{programa.Departamento.Departamento}",
                    $"{programa.Empresa.Direccion} {programa.Empresa.Ciudad}, {programa.Empresa.Estado}, {programa.Empresa.Pais}.",
                    $"{programa.Descripcion}",
                    $"{programa.Turno.Descripcion}"
                };
                
                service.WdReplaceTextInTableColumn(progArray);

                service.WdFindReplaceText("=NOMRESPONSABLE",
                    $"{programa.Responsable.Carrera.Abreviacion} {programa.Responsable.Nombre} {programa.Responsable.ApellidoPaterno} {programa.Responsable.ApellidoMaterno}");

                DateTime date = programa.Periodo.FechaAceptacion;
                CultureInfo cultInfo = new CultureInfo("es-MX");

                string upperMonth = cultInfo.DateTimeFormat.GetMonthName(date.Month).ToUpper()[0] + cultInfo.DateTimeFormat.GetMonthName(date.Month).Substring(1);
                string formattedMonth = date.ToString("d 'de' ") + upperMonth + date.ToString(" 'del' yyyy", cultInfo);

                service.WdFindReplaceText("=DATETIME",
                    formattedMonth);

                service.WdSaveFile();
                service.WdCloseFile();
                service.WdShutdown();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Hubo un problema con el documento de Word, omitiendo la generación del documento. ex " + ex.Message + " " + ex.Source + "\n" + ex.StackTrace);
                
                service.WdCloseFile();
                service.WdShutdown();

            }
            
        }
    }
}
