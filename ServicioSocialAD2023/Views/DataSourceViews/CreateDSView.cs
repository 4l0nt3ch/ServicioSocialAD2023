using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uanl_ss_main_ui.ControlHelpers;

namespace uanl_ss_main_ui.Views.DataSourceViews
{
    public partial class CreateDSView : Form
    {
        string name { get; set; }
        string tool { get; set; }
        public CreateDSView(string tool)
        {
            this.tool = tool;
            InitializeComponent();
        }

        private void BTCancelar(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CreateFile() {

            string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            switch (tool)
            {
                case "Microsoft Access":
                    ValidateFileCreation(Path.Combine(baseFolder, "UANL Servicio Social\\DataSources\\Microsoft Access\\" + name + ".mdb"));
                    break;
                case "Microsoft Excel":
                    ValidateFileCreation(Path.Combine(baseFolder, "UANL Servicio Social\\DataSources\\Microsoft Excel\\" + name + ".xls"));
                    break;
                case "SQL Server":
                    MessageBoxHelper.GetExclamationMessageBox("Característica no disponible", "Esta característica todavía está en desarrollo, lamentamos las molestias. " +
                        "También para recordarte que necesitarás de una instancia del SQL Server 2019 o 2022 instalado en el equipo servidor para que se cree de manera exitosa.");
                    // ValidateFileCreation(Path.Combine(baseFolder, "UANL Servicio Social/DataSources/Access/" + name + ".mdf"));
                    break;
            }
        }

        private void ValidateFileCreation(string path) {
            if (!File.Exists(path)) {
                using (FileStream fs = File.Create(path)) { fs.Close(); }
            }
            else
            {
                MessageBoxHelper.GetExclamationMessageBox("Archivo ya existe", "El archivo seleccionado ya fue creado.");
            }
        }

        private void BTAceptar(object sender, EventArgs e)
        {
            if (tbNombreCD.Text != null) {
                name = tbNombreCD.Text;
                CreateFile();
                Dispose();
            }
            else
            {
                MessageBoxHelper.GetExclamationMessageBox("Sin nombre", "Indica un nombre para el centro de datos.");
            }
        }
    }
}
