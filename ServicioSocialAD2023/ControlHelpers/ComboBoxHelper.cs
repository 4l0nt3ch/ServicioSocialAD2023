using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_main_ui.ControlHelpers
{
    public class ComboBoxHelper
    {
        public static string CBGetFileFormat(ComboBox cBox)
        {
            string format = string.Empty;
            switch (cBox.Text)
            {
                case "Microsoft Word":
                    format = "docx";
                    break;
                case "Aspose PDF":
                    format = "pdf";
                    break;
                default:
                    break;
            }
            return format;
        }

        public static string CBGetTemplate(ComboBox cbox)
        {
            string folder = string.Empty;
            switch (cbox.Text)
            {
                case "Boleta de Presentación":
                     folder = "BPSS";
                    break;
                case "Carta de Inicio":
                    folder = "CISS";
                    break;
                case "Kardex":
                    folder = "KRD";
                    break;
                default:
                    break;

            }
            return folder;
        } 

    }
}
