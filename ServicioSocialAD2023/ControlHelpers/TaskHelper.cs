using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using uanl_ss_lib_office_word_local_api.Engine;
using uanl_ss_lib_siase_api.SiaseService;
using uanl_ss_main_ui.Views.LoginViews;

namespace uanl_ss_main_ui.ControlHelpers
{
    public static class TaskHelper
    {
        public static async Task GenerateCITask(VistaProgreso VistaProg, List<CSPrograma> LSProgramas, CancellationTokenSource CTSource)
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

                    VistaProg.Show();

                    ParallelLoopResult loopRslt = Parallel.For(0, LSProgramas.Count, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }
                     , i =>
                     {

                         if (CTSource.IsCancellationRequested)
                         {
                             return;
                         }

                         lock (motorCPLock)
                         {
                             motorCP.CreateTemplateCI(LSProgramas[i]);
                         }

                         counter++;

                         VistaProg.CompleteProgressBar.Value = (counter * 100) / LSProgramas.Count;

                         VistaProg.lblBoletaActual.Text = lblProgCounter + counter.ToString() + " de " + (LSProgramas.Count).ToString() + " cartas de inicio.";
                     }
                    );

                    MessageBoxHelper.GetExclamationMessageBox("Exito", $"Tarea completa con éxito, {LSProgramas.Count} cartas de inicio generadas! Revise en el directorio de \"Mis Documentos\\UANLServicio Social\\Archives\\CISS\" para verificarlos.");

                    VistaProg.Dispose();

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

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            });
        }

        public static async Task GenerateBPTask(VistaProgreso VistaProg, List<CSPrograma> LSProgramas, CancellationTokenSource CTSource)
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

                    VistaProg.Show();

                    ParallelLoopResult loopRslt = Parallel.For(0, LSProgramas.Count, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }
                     , i =>
                     {

                         if (CTSource.IsCancellationRequested)
                         {
                             return;
                         }

                         lock (motorCPLock)
                         {
                             motorCP.CreateTemplateBP(LSProgramas[i]);
                         }

                         counter++;

                         VistaProg.CompleteProgressBar.Value = (counter * 100) / LSProgramas.Count;

                         VistaProg.lblBoletaActual.Text = lblProgCounter + counter.ToString() + " de " + (LSProgramas.Count).ToString() + " boletas.";
                     }
                    );

                    MessageBoxHelper.GetExclamationMessageBox("Exito", $"Tarea completa con éxito, {LSProgramas.Count} boletas de presentación generadas! Revise en el directorio de \"Mis Documentos\\UANLServicio Social\\Archives\\CPSS\" para verificarlos.");

                    VistaProg.Dispose();

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

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
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

            return await sServ.SSValidateToken(token);

        }
    }
}
 