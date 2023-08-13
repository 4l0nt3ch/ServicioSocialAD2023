using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_main_ui.ControlHelpers
{
    public class ConfigurationHelper
    {
        private Configuration config;

        public ConfigurationHelper() {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public Configuration GetConfiguration() {
            return config;
        }

        #region ConfigurationNodes
        /// <summary>
        /// Escribe el valor de un nodo en el archivo de configuración.
        /// </summary>
        /// <param name="nodeName"></param>
        /// <param name="value"></param>
        public void WConfigNode(string nodeName, string value) {
            if (config.AppSettings.Settings[nodeName] == null)
            {
                config.AppSettings.Settings.Add(nodeName, value);
            }
            else { 
                config.AppSettings.Settings[nodeName].Value = value;
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        /// <summary>
        /// Obtiene el valor de un nodo en el archivo de configuración.
        /// </summary>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public string RConfigNode(string nodeName) { 
            if (config.AppSettings.Settings[nodeName] != null)
            {
                return config.AppSettings.Settings[nodeName].Value;
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion
        #region ComboBoxAdapters

        public void RCBSelectedNode(ComboBox cb, string nodeName) {
            string nodeValue = RConfigNode(nodeName);

            if (nodeValue != null && nodeValue != string.Empty)
            {
                cb.Text = nodeValue;
            }
            else { 
                cb.Text = string.Empty;
            }
        }

        public void WCBSelectedNode(ComboBox cb, string nodeName)
        {
            if (cb.SelectedValue.ToString() != string.Empty &&
                cb.SelectedValue.ToString() != null)
            {
                WConfigNode(nodeName,cb.SelectedValue.ToString());
            }
        }

        #endregion
        #region TextBoxAdapters
        /// <summary>
        /// Lee los datos y los muestra en un control de TextBox.
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="nodeName"></param>
        public void RTBStringNode(TextBox txt, string nodeName)
        {
            string nodeValue = RConfigNode(nodeName);

            if (nodeValue != null && nodeValue != string.Empty)
            {
                txt.Text = nodeValue;
            }
            else
            {
                txt.Text = string.Empty;
            }
        }
        /// <summary>
        /// Escribe el valor de un TextBox en el archivo de configuración.
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="nodeName"></param>
        public void WTBStringNode(TextBox txt, string nodeName)
        {
            if (txt.Text != string.Empty && txt.Text != null) {
                WConfigNode(nodeName,txt.Text.ToString());
            }
        }

        #endregion
        #region RadioButtonAdapters
        /// <summary>
        /// Lee los datos y los muestra en un control de RadioButton.
        /// </summary>
        /// <param name="rb"></param>
        /// <param name="nodeName"></param>
        public void RRBValueNode (RadioButton rb, string nodeName)
        {
            string nodeNameValue = RConfigNode(nodeName);

            if (nodeNameValue != null && nodeNameValue != string.Empty) { 
                if (nodeNameValue.Equals("True"))
                {
                    rb.Checked = true;
                }
                else
                {
                    rb.Checked = false;
                }
            }
        }
        /// <summary>
        /// Escribe el valor de un RadioButton en el archivo de configuración.
        /// </summary>
        /// <param name="rb"></param>
        /// <param name="nodeName"></param>
        public void WRBValueNode (RadioButton rb, string nodeName) {           
            if(rb.Checked) {
                WConfigNode(nodeName, rb.Checked.ToString());
            }
            else
            {
                WConfigNode(nodeName, rb.Checked.ToString());
            }
        }

        #endregion
        #region CheckBoxAdapters
        /// <summary>
        /// Lee los datos y los muestra en un control de CheckBox.
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="nodeName"></param>
        public void RChBValueNode (CheckBox cb, string nodeName)
        {
            string nodeNameValue = RConfigNode(nodeName);

            if (nodeNameValue != null && nodeNameValue != string.Empty) { 
                if (nodeNameValue.Equals ("True"))
                {
                    cb.Checked = true;
                }
                else
                {
                    cb.Checked = false;
                }
            }
        }
        /// <summary>
        /// Escribe el valor de un CheckBox en el archivo de configuración.
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="nodeName"></param>
        public void WChValueNode (CheckBox cb, string nodeName)
        {
            if (cb.Checked)
            {
                WConfigNode(nodeName, cb.Checked.ToString());
            }
            else
            {
                WConfigNode(nodeName, cb.Checked.ToString());
            }
        }

        #endregion
    }
}
