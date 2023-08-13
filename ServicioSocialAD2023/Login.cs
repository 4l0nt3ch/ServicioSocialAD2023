using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uanl_ss_main_ui
{
    public partial class Login : Form
    {
        private MainForm mForm;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLoginEventClick(object sender, EventArgs e)
        {
            if (mForm != null)
            {
                mForm.Dispose(); // Liberar memoria del formulario actual
                mForm = null;
            }

            mForm = new MainForm();
            mForm.FormClosed += (s, args) =>
            {
                mForm.Dispose();
                mForm = null;
                TBUser.Text = string.Empty;
                TBPassword.Text = string.Empty;
                this.Show();
            }; // Mostrar formulario actual al cerrar el nuevo formulario
            mForm.Show(); // Mostrar nuevo formulario
            Hide();
        }

        private void BTExitAppEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtOpenRA(object sender, EventArgs e)
        {
            VistaAcceso vistaA  = new VistaAcceso();
            vistaA.ShowDialog();
        }
    }
}
