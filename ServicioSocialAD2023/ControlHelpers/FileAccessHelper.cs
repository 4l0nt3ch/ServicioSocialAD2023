using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using uanl_ss_lib_xml_local_api;
using uanl_ss_main_ui.Entities;

namespace uanl_ss_main_ui.ControlHelpers
{
    public class FileAccessHelper
    {
        public static string CreateFileDirectory(string path)
        {
            if (!File.Exists(path))
            {
                XmlCrud<RepoConfiguration> repoConfig = new XmlCrud<RepoConfiguration>(path);

                repoConfig.CreateFile();

                return path;
            }
            else
            {
                return path;
            }
        }
    }
}
