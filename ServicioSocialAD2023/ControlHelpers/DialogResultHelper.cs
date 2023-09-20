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
        public static string OpenFileDialogFlow(string formatFile) {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                string path = String.Empty;
                string newPath = String.Empty;

                fileDialog.Title = "Seleccionar archivo";

                switch (formatFile) { 
                    case "Microsoft Excel":
                        fileDialog.Filter = "Archivos Excel (*.xls)|*.xls";
                        break;
                    case "Microsoft Access":
                        fileDialog.Filter = "Archivos Excel (*.mdb)|*.mdb";
                        break;
                }

                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                DialogResult result = fileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {

                    path = fileDialog.FileName;
                    newPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                            , $"UANL Servicio Social\\DataSources\\{formatFile}\\{Path.GetFileName(path)}");

                    if (!File.Exists(newPath))
                    {
                        File.Copy(path, newPath);
                    }
                    else
                    {
                        MessageBoxHelper.GetExclamationMessageBox("Operación detenida", "El archivo seleccionado ya existe.");
                    }

                    MessageBoxHelper.GetExclamationMessageBox("Operación correcta", "Archivo seleccionado con éxito.");
                    return newPath;
                }
                else
                {
                    MessageBoxHelper.GetExclamationMessageBox("Operación errónea", "No indicaste ningún archivo, asegúrate que hayas seleccionado uno, y oprime el botón \"Aceptar\"");
                    return newPath;
                }
            } catch (Exception ex) {
                MessageBoxHelper.GetErrorMessageBox("Operación fallida", "Se obtuvo un problema con la lectura de la ruta del archivo... ", ex);
                return string.Empty;
            }
        }
    }
}
