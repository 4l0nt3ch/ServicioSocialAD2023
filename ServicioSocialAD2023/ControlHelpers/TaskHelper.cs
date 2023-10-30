using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using uanl_ss_lib_office_word_local_api.Engine;
using uanl_ss_lib_siase_api.SiaseService;
using uanl_ss_main_ui.Views.LoginViews;

namespace uanl_ss_main_ui.ControlHelpers
{
    public static class TaskHelper
    {
        public static async Task GenerateCITask(VistaProgreso VistaProg, List<CSPrograma> LSProgramas, CancellationTokenSource CTSource, string arrangeType)
        {
            await Task.Run(async () =>
            {
                try
                {
                    object motorCPLock = new object();
                    MotorCP motorCP = new MotorCP();

                    int counter = 0;
                    string lblProgCounter = VistaProg.lblBoletaActual.Text.ToString();
                    VistaProg.CompleteProgressBar.Maximum = 100;
                    VistaProg.CompleteProgressBar.Value = 0;

                    ParallelLoopResult loopRslt = Parallel.For(0, LSProgramas.Count, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }
                     , i =>
                     {

                         if (CTSource.IsCancellationRequested)
                         {
                             return;
                         }

                         lock (motorCPLock)
                         {
                             string fileName = $"{LSProgramas[i].Alumno.Matricula}_" +
                                               $"{LSProgramas[i].Alumno.Nombre.ToUpper()}_{LSProgramas[i].Alumno.ApellidoPaterno.ToUpper()}" +
                                               $"_{LSProgramas[i].Alumno.ApellidoMaterno.ToUpper()}";

                             string[] files = Directory.GetFiles(
                                 Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", "CISS"),
                                 "*",
                                 SearchOption.AllDirectories).Where(
                                    f => Path.GetFileNameWithoutExtension(f) == fileName
                                 ).ToArray();

                             if (files.Length > 0)
                             {
                                 FileAccessHelper.RearrangeFileToOtherLocation(files, "CISS", arrangeType, LSProgramas[i]);
                             }
                             else
                             {
                                 motorCP.WdCreateTemplateCI(LSProgramas[i],
                                 FileAccessHelper.SaveFileToLocation("CISS", arrangeType, LSProgramas[i], "docx"));
                             }               
                         }

                         counter++;

                         VistaProg.CompleteProgressBar.Value = (counter * 100) / LSProgramas.Count;

                         VistaProg.lblBoletaActual.Text = lblProgCounter + counter.ToString() + " de " + (LSProgramas.Count).ToString() + " cartas de inicio.";
                     }
                    );

                    MessageBoxHelper.GetExclamationMessageBox("Exito", $"Tarea completa con éxito, {LSProgramas.Count} cartas de inicio generadas! Revise en el directorio de \"Mis Documentos\\UANLServicio Social\\Archives\\CISS\" para verificarlos.");
                }
                catch (OperationCanceledException)
                {
                    MessageBoxHelper.GetExclamationMessageBox("Error", "El usuario abortó la operación.");
                }
                catch (Exception ex)
                {
                    MessageBoxHelper.GetErrorMessageBox("Error", "Hubo un problema en la generación del documento de Word", ex);
                }
                finally
                {
                    CTSource.Dispose();
                    CTSource = null;

                    VistaProg.Close();

                    GC.Collect();
                    GC.WaitForPendingFinalizers();               
                }
            });
        }

        public static async Task GenerateBPTask(VistaProgreso VistaProg, List<CSPrograma> LSProgramas, CancellationTokenSource CTSource, string arrangeType)
        {
            await Task.Run(async () =>
            {
                try
                {
                    object motorCPLock = new object();
                    MotorCP motorCP = new MotorCP();

                    int counter = 0;
                    string lblProgCounter = VistaProg.lblBoletaActual.Text.ToString();
                    VistaProg.CompleteProgressBar.Maximum = 100;
                    VistaProg.CompleteProgressBar.Value = 0;

                    ParallelLoopResult loopRslt = Parallel.For(0, LSProgramas.Count, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }
                     , i =>
                     {

                         if (CTSource.IsCancellationRequested)
                         {
                             return;
                         }

                         lock (motorCPLock)
                         {
                             string fileName = $"{LSProgramas[i].Alumno.Matricula}_" +
                                               $"{LSProgramas[i].Alumno.Nombre.ToUpper()}_{LSProgramas[i].Alumno.ApellidoPaterno.ToUpper()}" +
                                               $"_{LSProgramas[i].Alumno.ApellidoMaterno.ToUpper()}";

                             string[] files = Directory.GetFiles(
                                 Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"UANL Servicio Social","Archives","BPSS"),
                                 "*",
                                 SearchOption.AllDirectories).Where(
                                    f =>  Path.GetFileNameWithoutExtension(f) == fileName
                                 ).ToArray();

                             if (files.Length > 0)
                             {
                                 FileAccessHelper.RearrangeFileToOtherLocation(files, "BPSS", arrangeType, LSProgramas[i]);
                             }
                             else
                             {
                                 motorCP.WdCreateTemplateBP(LSProgramas[i],
                                 FileAccessHelper.SaveFileToLocation("BPSS", arrangeType, LSProgramas[i], "docx"));
                             }                           
                         }

                         counter++;

                         VistaProg.CompleteProgressBar.Value = (counter * 100) / LSProgramas.Count;

                         VistaProg.lblBoletaActual.Text = lblProgCounter + counter.ToString() + " de " + (LSProgramas.Count).ToString() + " boletas.";
                     }
                    );

                    MessageBoxHelper.GetExclamationMessageBox("Exito", $"Tarea completa con éxito, {LSProgramas.Count} boletas de presentación generadas! Revise en el directorio de \"Mis Documentos\\UANLServicio Social\\Archives\\CPSS\" para verificarlos.");

                    
                }
                catch (OperationCanceledException)
                {
                    MessageBoxHelper.GetExclamationMessageBox("Error", "El usuario abortó la operación.");
                }
                catch (Exception ex)
                {
                    MessageBoxHelper.GetErrorMessageBox("Error", "Hubo un problema en la generación del documento de Word", ex.InnerException);
                }
                finally
                {
                    CTSource.Dispose();
                    CTSource = null;

                    VistaProg.Close();

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            });
        }

        public static async Task arrangeFiles(List<CSPrograma> selProgramas, string importTool, string ExportFilter, string TemplateEngine,
            ListViewHelper lvHelper)
        {
            await Task.Run(async () =>
            {
                if (selProgramas != null)
                {
                    int counter = 0;

                    LoadingSession session = new LoadingSession();
                    session.ShowDialog();

                    session.lblStatus.Text = "Iniciando operación...";

                    foreach (CSPrograma prog in selProgramas)
                    {

                        session.lblStatus.Text = $"Reacomodando {counter++} documentos por {ExportFilter}. Por favor espere";

                        string[] files = Directory.GetFiles(
                                         Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social", "Archives", TemplateEngine),
                                         "*",
                                         SearchOption.AllDirectories).ToArray();

                        if (files.Length > 0)
                        {
                            FileAccessHelper.RearrangeFileToOtherLocation(files, TemplateEngine, ExportFilter, prog);
                        }

                        counter++;
                    }

                    session.lblStatus.Text = "Operación exitosa";

                    if (importTool.Equals("Microsoft Excel"))
                    {
                        lvHelper.UpdateListView("Excel", null, null, null);
                    }

                    MessageBoxHelper.GetExclamationMessageBox("Exito", "Los archivos han sido reacomodados con éxito");

                    session.Close();
                }
                else
                {
                    MessageBoxHelper.GetExclamationMessageBox("DataSource no definido", "Datos no definidos para reestucutración de exportación de documentos");
                }
            });        
        }

        public static async Task<bool> Login(string user, string password)
        {
            LoadingSession session = new LoadingSession();
            session.Show();

            SiaseService sServ = new SiaseService(user, password);

            session.lblStatus.Text = "Conectando a SIASE API, generando token de usuario...";

            string token = await sServ.SSGenerateSessionToken();

            session.lblStatus.Text = "Validando token generado...";

            session.Dispose();

            return await sServ.SSValidateToken(token);

        } 
    }
}
 