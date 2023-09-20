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
    public partial class VistaPrograma : Form
    {
        public VistaPrograma()
        {
            InitializeComponent();
        }

        private void BTEventQuit(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BTCDEvent(object sender, EventArgs e)
        {
            VistaDepartamento vistaD = new VistaDepartamento();
            vistaD.ShowDialog();
        }

        private void BTCTEvent(object sender, EventArgs e)
        {
            VistaTipo vistaT = new VistaTipo();
            vistaT.ShowDialog();
        }

        private void BTCCEvent(object sender, EventArgs e)
        {
            VistaComunidad vistaC = new VistaComunidad();
            vistaC.ShowDialog();
        }

        private void BTCAEvent(object sender, EventArgs e)
        {
            VistaActividad vistaA = new VistaActividad();
            vistaA.ShowDialog();
        }

        private void VistaPrograma_Load(object sender, EventArgs e)
        {

        }

        private void BTExit_Click(object sender, EventArgs e)
        {

        }

        private void BTConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
