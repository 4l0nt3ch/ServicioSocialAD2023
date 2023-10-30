using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;

namespace uanl_ss_lib_office_excel_local_api.Helpers
{
    public class ImageHelpers
    {
        public static string ConvertImageToBase64(string imagePath)
        {
            try
            {

                // Obtener la ubicación del ensamblado actual
                string assemblyLocation = Assembly.GetExecutingAssembly().Location;

                // Obtener el directorio del ensamblado
                string assemblyDirectory = Path.Combine(System.IO.Path.GetDirectoryName(assemblyLocation),imagePath);

                // Lee la imagen desde el archivo especificado
                byte[] imageBytes = File.ReadAllBytes(imagePath);

                // Convierte los bytes de la imagen a una cadena Base64
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                System.Diagnostics.Debug.WriteLine("Error al convertir la imagen a Base64: " + ex.Message);
                return null;
            }
        }
    }
}
