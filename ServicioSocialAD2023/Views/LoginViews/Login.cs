using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uanl_ss_main_ui.ControlHelpers;

namespace uanl_ss_main_ui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private async void BtnLoginEventClick(object sender, EventArgs e)
        {

            Hide();

            if (await TaskHelper.Login(TBUser.Text, TBPassword.Text))
            {
                FormClosingEvt(null, null);
            }
            else
            {
                Show();
                MessageBoxHelper.GetExclamationMessageBox("Datos erróneos", "Las credenciales proporcionadas no son válidas.");
            }

        }

        private void BTExitAppEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtOpenRA(object sender, EventArgs e)
        {
            VistaAcceso vistaA = new VistaAcceso();
            vistaA.ShowDialog();
        }

        private void FormClosingEvt(object sender, FormClosingEventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
        }
    }
}
