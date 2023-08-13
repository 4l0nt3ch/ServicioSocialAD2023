using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_office_word_local_api.MinimalAdapterClass;
using uanl_ss_lib_office_word_local_api.Service;

namespace uanl_ss_lib_office_word_local_api.Engine
{
    public class MotorCP
    {
        public WordService service { get; set; }

        public MotorCP() {
            service = GetWordService();
        }

        public WordService GetWordService() {
            if (service == null)
            {
                return new WordService();
            }
            else { 
                return service;
            }
        }

        public static void GetWordServiceAsync()
        {


        }

    }
}
