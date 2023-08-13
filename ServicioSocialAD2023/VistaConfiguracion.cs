using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uanl_ss_lib_xml_local_api;
using uanl_ss_main_ui.ControlHelpers;
using uanl_ss_main_ui.Entities;

namespace uanl_ss_main_ui
{
    public partial class VistaConfiguracion : Form
    {
        private XmlCrud<RepoConfiguration> configRepo;
        private string configRepoPath;
        public VistaConfiguracion()
        {
            InitializeComponent();
            configRepoPath = FileAccessHelper.CreateFileDirectory(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "repoServers.xml"));

            configRepo = new XmlCrud<RepoConfiguration>(configRepoPath);
            UpdateRepositoryCB();
        }

        private void ButtonSaveRepository_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBPassword.Text.Equals(TBPassConfirm.Text))
                {
                    RepoConfiguration instance = new RepoConfiguration(
                    configRepoPath,
                    TXTNombre.Text,
                    SelectServerType(),
                    TBServer.Text,
                    TBPort.Text,
                    TBUser.Text,
                    TBPassword.Text
                    );

                    configRepo.CreateObject(instance);

                    MessageBoxHelper.GetExclamationMessageBox(
                        "Anidación exitosa",
                        "Instancia de repositiorio añadida con éxito"
                        );
                }
                else
                {
                    MessageBoxHelper.GetExclamationMessageBox(
                        "Error al añadir repositorio",
                        "Las contraseñas indicadas no coinciden"
                        );
                }

                UpdateRepositoryCB();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.GetErrorMessageBox(
                    "Error al añadir repositorio",
                    "Hubo un error en la creación de la instancia de repositorio... ",
                    ex
                    );
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteRepository_Click(object sender, EventArgs e)
        {
            if (CBRepo.SelectedIndex != -1 && CBRepo.SelectedIndex < CBRepo.Items.Count)
            {
                configRepo.DeleteObject(CBRepo.SelectedIndex);
            }

            UpdateRepositoryCB();

        }


        private void ButtonModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBPassword.Text.Equals(TBPassConfirm.Text))
                {
                    RepoConfiguration instance = new RepoConfiguration(
                    configRepoPath,
                    TXTNombre.Text,
                    SelectServerType(),
                    TBServer.Text,
                    TBPort.Text,
                    TBUser.Text,
                    TBPassword.Text
                    );

                    if (CBRepo.SelectedIndex != -1 && CBRepo.SelectedIndex < CBRepo.Items.Count)
                    {
                        configRepo.UpdateObject(
                            instance,
                            CBRepo.SelectedIndex);
                    }

                    MessageBoxHelper.GetExclamationMessageBox(
                        "Anidación exitosa",
                        "Instancia de repositiorio añadida con éxito"
                        );

                    UpdateRepositoryCB();
                }
                else
                {
                    MessageBoxHelper.GetExclamationMessageBox(
                        "Error al añadir repositorio",
                        "Las contraseñas indicadas no coinciden"
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.GetErrorMessageBox(
                    "Error al añadir repositorio",
                    "Hubo un error en la creación de la instancia de repositorio... ",
                    ex
                    );
            }
        }

        private void CBRepoSelectedValueChanged(object sender, EventArgs e)
        {
            if (CBRepo.SelectedIndex != -1 && CBRepo.SelectedIndex < CBRepo.Items.Count) {
                RepoConfiguration instance = configRepo.GetSelected(CBRepo.SelectedIndex);

                if (instance != null)
                {
                    SetServerTypeSelected(instance);
                    TXTNombre.Text = instance.RCName;
                    CBAmbiente.Text = instance.RCType;
                    TBServer.Text = instance.RCHostServer;
                    TBPort.Text = instance.RCHostPort;
                    TBUser.Text = instance.RCMasterUser;
                    TBPassword.Text = instance.RCMasterPassword;
                }
            }
        }

        private string SelectServerType()
        {
            if (RBPhysicalServer.Checked)
            {
                return RBPhysicalServer.Text;
            }
            else if (RBSharePoint.Checked)
            {
                return RBSharePoint.Text;
            }
            else
            {
                return "Default";
            }
        }

        private void SetServerTypeSelected(RepoConfiguration instance)
        {
            if (instance.RCType.Equals(RBSharePoint.Text))
            {
                RBSharePoint.Enabled = true;
            }
            if (instance.RCType.Equals(RBPhysicalServer.Text))
            {
                RBPhysicalServer.Enabled = true;
            }
        }

        private void UpdateRepositoryCB() {
            List<RepoConfiguration> list = configRepo.GetAll();
            CBRepo.Items.Clear();

            foreach (RepoConfiguration item in list) {
                CBRepo.Items.Add(item.RCName);
            }
        }

        #region UnusedEvents
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonUseRepository_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
