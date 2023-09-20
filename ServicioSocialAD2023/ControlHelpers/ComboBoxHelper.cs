using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_main_ui.ControlHelpers
{
    internal class ComboBoxHelper
    {
        public static string Formato(ComboBox comboBox)
        {
            string selectedItem = comboBox.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Microsoft Word":
                    return "docx";
                case "Adobe PDF":
                    return "pdf";
                default:
                    throw new ArgumentException("Formato no válido");
            }
        }

        public static string Template(ComboBox comboBox)
        {
            string selectedItem = comboBox.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Boleta de presentación":
                    return "BPSS";
                case "Carta de inicio":
                    return "CISS";
                case "Kardex":
                    return "KRD";
                case "Carta Finalización":
                    return "CFSS";
                case "Evaluación":
                    return "EVL";
                default:
                    throw new ArgumentException("Plantilla no válida");
            }
        }
    }
}
