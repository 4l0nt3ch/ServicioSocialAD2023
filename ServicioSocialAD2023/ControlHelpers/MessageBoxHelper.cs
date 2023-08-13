using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_main_ui.ControlHelpers
{
    public class MessageBoxHelper
    {
        public static DialogResult GetErrorMessageBox(string WindowName, string Description, Exception ex)
        {
            return MessageBox.Show(Description + "ex. " + ex.StackTrace,
                WindowName, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult GetExclamationMessageBox(string WindowName, string Description) { 
            return MessageBox.Show(Description,
                WindowName, MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        public static DialogResult GetQuestionMessageBox(string WindowName, string Description) { 
            return MessageBox.Show(Description,
                WindowName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
