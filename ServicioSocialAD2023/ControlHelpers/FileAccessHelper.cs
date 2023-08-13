using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_main_ui.ControlHelpers
{
    public class FileAccessHelper
    {
        public static string CreateFileDirectory(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(String.Empty);
            }
            return path;
        }
    }
}
