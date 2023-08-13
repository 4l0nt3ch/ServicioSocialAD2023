using System.Drawing.Printing;
using uanl_ss_main_ui.ControlHelpers;

namespace uanl_ss_main_ui
{
    public partial class MainForm : Form
    {
        private ListViewHelper lvHelper { get; set; }   
        private string fileLocation { get; set; }
        private ConfigurationHelper configHelper { get; set; }
        public MainForm()
        {
            InitializeComponent();
            configHelper = new ConfigurationHelper();

            if (configHelper.GetConfiguration().AppSettings.Settings == null) {
                BuildConfiguration();
            }
        }

        private void DivPanelInfoClick(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void BTPCEvent(object sender, EventArgs e)
        {
            VistaPrograma vistaP = new VistaPrograma();
            vistaP.ShowDialog();
        }

        private void BTCCreate(object sender, EventArgs e)
        {
            VistaCoordinador vista = new VistaCoordinador();
            vista.ShowDialog();
        }

        private void BTARClick(object sender, EventArgs e)
        {
            VistaResponsable vistaR = new VistaResponsable();
            vistaR.ShowDialog();
        }

        private void BTAPClick(object sender, EventArgs e)
        {
            VistaPeriodo vistaP = new VistaPeriodo();
            vistaP.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfigurationClock(object sender, EventArgs e)
        {
            VistaConfiguracion vistaC = new VistaConfiguracion();
            vistaC.ShowDialog();
        }

        private void ButtonImportEvent(object sender, EventArgs e)
        {
            DialogResultHelper.OpenFileDialogFlow("Excel", Environment.SpecialFolder.MyDocuments.ToString());
        }

        #region Lectura y Modificación de Configuración
        private void BuildConfiguration() {

            

        }
        #endregion

        private void ListViewUpdateEvent(object sender, EventArgs e)
        {
            string tool = cbHerramienta.Text;

            switch (tool)
            {
                case "Excel":
                    ListViewUpdateExcel();
                    break;
                default:
                    MessageBoxHelper.GetQuestionMessageBox("Operación fallida", "Indique la tecnología de lectura de la fuente de datos.");
                    break;
            }
        }

        private void ListViewUpdateExcel() {
            if (!cbLocalSource.Text.Equals(null) && CBUsingRepositoryFile.Checked)
            {
                lvHelper = new ListViewHelper(
                    ListViewMain,
                    btnPagAnterior,
                    btnPagSiguiente,
                    tbPagination,
                    tbBatch,
                    Int32.Parse(tbBatch.Text),
                    fileLocation,
                    "in"
                    );
            }
            else if (!tbDataSource.Equals(null) && !CBUsingRepositoryFile.Checked)
            {
                lvHelper = new ListViewHelper(
                    ListViewMain,
                    btnPagAnterior,
                    btnPagSiguiente,
                    tbPagination,
                    tbBatch,
                    Int32.Parse(tbBatch.Text),
                    fileLocation,
                    "in"
                    );
            }
            else
            {
                MessageBoxHelper.GetExclamationMessageBox("Error de operación", "Indique solo una fuente de datos, no se puede tener dos fuentes cargadas a la vez.");
            }
        }

        private void LocalRepositoryEnabled(object sender, EventArgs e)
        {
            if (CBUsingRepositoryFile.Checked)
            {
                tbDataSource.Text = null;
                tbDataSource.Enabled = false;
                ButtonImportFile.Enabled = false;
                cbLocalSource.Enabled = true;
                ButtonLoadDS.Enabled = true;
            }
            else {
                cbLocalSource.Enabled = false;
                cbLocalSource.SelectedItem = -1;
                cbLocalSource.Text = null;
                ButtonLoadDS.Enabled = false;
                tbDataSource.Enabled = true;
                ButtonImportFile.Enabled = true;
            }
        }

        private void ButtonImportFileEvent(object sender, EventArgs e)
        {
            string tool = cbHerramienta.Text;

            switch (tool)
            {
                case "Excel":
                    fileLocation = DialogResultHelper.OpenFileDialogFlow(tool, Environment.SpecialFolder.MyDocuments.ToString());
                    if (fileLocation != null) {
                        tbDataSource.Text = fileLocation; 
                    }
                    else {
                        MessageBoxHelper.GetExclamationMessageBox("Error desconocido", "No se pudo cargar el documento, intente de nuevo...");
                    }
                    break;
                default:
                    MessageBoxHelper.GetExclamationMessageBox("Operación fallida", "Indique la tecnología de lectura de la fuente de datos.");
                    break;
            }        
        }

        private void ButtonAddPaginationBatchClick(object sender, EventArgs e)
        {
            if (Int32.Parse(tbBatch.Text) < 99)
            {
                tbBatch.Text = (Int32.Parse(tbBatch.Text.ToString()) + 1).ToString();
            }
            else
            {
                MessageBoxHelper.GetExclamationMessageBox("Operación no valida", "Ya no se puede aumentar el lote deseado a más de 100 registros.");
            }
        }

        private void ButtonRemPaginationBatchClick(object sender, EventArgs e)
        {
            if (Int32.Parse(tbBatch.Text) > 1)
            {
                tbBatch.Text = (Int32.Parse(tbBatch.Text.ToString()) - 1).ToString();
            }
            else {
                MessageBoxHelper.GetExclamationMessageBox("Operación no valida", "Ya no se puede reducir el lote deseado a menos de 0 registros.");
            }
        }

        private void BtnPagAnteriorClick(object sender, EventArgs e)
        {
            if (lvHelper != null)
            {
                if (lvHelper.currentPage > 1)
                {
                    lvHelper.currentPage--;
                    lvHelper.UpdateListView();
                }
            }
            else {
                MessageBoxHelper.GetExclamationMessageBox("Operación fallida", "Actualice la lista solicitada para poder navegar en ella.");
            }
        }

        private void BtnPagSiguienteClick(object sender, EventArgs e)
        {
            if (lvHelper != null) { 
                if (lvHelper.currentPage < (int) Math.Ceiling((double)lvHelper.recordList.Count / lvHelper.itemsPerPage)) {
                    lvHelper.currentPage++;
                    lvHelper.UpdateListView();
                }
            }
        }
    }
}