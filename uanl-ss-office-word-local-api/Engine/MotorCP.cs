using uanl_ss_lib_office_word_local_api.Service;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using System.Reflection;
using System.Globalization;
using System;
using uanl_ss_lib_office_word_local_api.Helpers;

namespace uanl_ss_lib_office_word_local_api.Engine
{
    public class MotorCP
    {
        public WordService service { get; set; }

        public MotorCP() {}

        public void WdCreateTemplateCI(CSPrograma programa, string fileLocation)
        {
            try
            {
                service = new WordService();

                Document doc = service.WdOpenTmplFile("Carta de Inicio V1.docx", String.Empty);

                if (!Directory.Exists(Path.GetDirectoryName(fileLocation))) {
                    Directory.CreateDirectory(Path.GetDirectoryName(fileLocation));         
                }

                string filePath = Path.Combine(fileLocation);

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

                ImageHelper.imageShape(
                    "Firma",
                    doc,
                    Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Firma MAGC.png"),
                    50f,
                    5f,
                    (0.69f * 72f),
                    (0.78f * 72f)
                    );

                ImageHelper.imageShape(
                    "Sello",
                    doc,
                    Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sello MAGC.jpg"),
                    0f,
                    0f,
                    (1.40f * 72f),
                    (2.18f * 72f)
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

        public void WdCreateTemplateBP(CSPrograma programa, string fileLocation) {
            try
            {
                service = new WordService();

                Document doc = service.WdOpenTmplFile("Boleta de Presentación V1.docx", String.Empty);

                if (!Directory.Exists(Path.GetDirectoryName(fileLocation)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fileLocation));
                }

                string filePath = Path.Combine(fileLocation);

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

                ImageHelper.imageShape(
                    "FirmaAceptado",
                    doc,
                    Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Firma MAGC.png"),
                    50f,
                    20f,
                    (0.78f * 72f),
                    (0.90f * 72f)
                    );

                ImageHelper.imageShape(
                    "Sello",
                    doc,
                    Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sello MAGC.jpg"),
                    70f,
                    50f,
                    (1.40f * 72f),
                    (2.18f * 72f)
                    );

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
