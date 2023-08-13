using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uanl_ss_main_ui.ControlHelpers
{
    public class DialogResultHelper
    {
        private static ConfigurationHelper helper;
        /// <summary>
        /// Retorna el directorio seleccionado de un archivo y da la posiblidad de copiarlo al repositorio local o remoto.
        /// </summary>
        /// <param name="formatFile"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string OpenFileDialogFlow(string formatFile, string filePath) {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                string path = String.Empty;

                fileDialog.Title = "Seleccionar archivo";

                if (formatFile == "Excel")
                {
                    fileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                }

                fileDialog.InitialDirectory = filePath;

                DialogResult result = fileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    DialogResult saveFileDialog = MessageBoxHelper.GetQuestionMessageBox("Guardar archivo excel",
                        "¿Deseas guardar el archivo en el repositorio? No necesitarás de añadir nuevamente el archivo.");

                    if (DialogResult.OK == saveFileDialog)
                    {
                        helper = new ConfigurationHelper();

                        string remotePath = helper.RConfigNode("RepositoryPath");
                        remotePath = Path.Combine(path, "datasets\\");
                        string fileName = Path.GetFileName(filePath);

                        if (!File.Exists(path))
                        {
                            File.Copy(filePath, remotePath);
                        }
                        else {
                            MessageBoxHelper.GetExclamationMessageBox("Operación abortada",
                                "Este archivo ya existe.");
                        }
                    }

                    path = fileDialog.FileName;
                    MessageBoxHelper.GetExclamationMessageBox("Operación correcta", "Archivo seleccionado con éxito.");

                    return path;
                }
                else
                {
                    MessageBoxHelper.GetExclamationMessageBox("Operación errónea", "No indicaste ningún archivo, asegúrate que hayas seleccionado uno, y oprime el botón \"Aceptar\"");
                    return path;
                }
            } catch (Exception ex) {
                MessageBoxHelper.GetErrorMessageBox("Operación fallida", "Se obtuvo un problema con la lectura de la ruta del archivo... ", ex);
                return string.Empty;
            }
        }
    }
}
