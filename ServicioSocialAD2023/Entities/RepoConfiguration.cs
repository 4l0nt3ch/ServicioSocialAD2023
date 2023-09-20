using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using uanl_ss_lib_xml_local_api;

namespace uanl_ss_main_ui.Entities
{
    [Serializable]
    public class RepoConfiguration
    {
        [XmlAttribute]
        public string filePath { get; set; }
        [XmlAttribute]
        public string RCName { get; set; }
        [XmlAttribute]
        public string RCType { get; set; }
        [XmlAttribute]
        public string RCEnv { get; set; }
        [XmlAttribute]
        public string RCHostServer { get; set; }
        [XmlAttribute]
        public string RCHostPort { get; set; }
        [XmlAttribute]
        public string RCMasterUser { get; set; }
        [XmlAttribute]
        public string RCMasterPassword { get; set; }
        public RepoConfiguration() { }
        public RepoConfiguration(string filePath, string rCName, string rCType, string rCEnv, string rCHostName, 
            string rCHostPort, string rCMasterUser, string rCMasterPassword)
        {
            this.filePath = filePath;
            this.RCName = rCName;
            this.RCType = rCType;
            this.RCEnv = rCEnv;
            this.RCHostServer = rCHostName;
            this.RCHostPort = rCHostPort;
            this.RCMasterUser = rCMasterUser;
            this.RCMasterPassword = rCMasterPassword;
        }

        
    }
}
