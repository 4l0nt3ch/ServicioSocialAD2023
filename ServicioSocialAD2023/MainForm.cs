using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using uanl_ss_lib_office_excel_local_api.MinimalAdapterClass;
using uanl_ss_main_ui.ControlHelpers;
using uanl_ss_main_ui.Views.DataSourceViews;

namespace uanl_ss_main_ui
{
    public partial class MainForm : Form
    {
        private ListViewHelper lvHelper { get; set; }   
        private string fileLocation { get; set; }
        private ConfigurationHelper configHelper { get; set; }
        private FileSystemWatcher watcher { get; set; }
        private string DAdirectory { get; set; }
        public MainForm()
        {
            InitializeComponent();
            ResizeMainScreen();
            
            DAdirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UANL Servicio Social\\DataSources\\");

            watcher = new FileSystemWatcher();
            watcher.Path = DAdirectory;
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Changed += FileSystemWatcher_Changed;
            watcher.Created += FileSystemWatcher_Created;
            watcher.Deleted += FileSystemWatcher_Deleted;
            watcher.Renamed += FileSystemWatcher_Renamed;

            watcher.EnableRaisingEvents = true;

            configHelper = new ConfigurationHelper();

            CheckForIllegalCrossThreadCalls = false;

            if (configHelper.GetConfiguration().AppSettings.Settings == null) {
                BuildConfiguration();
            }
        }

        public void ResizeMainScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            RegisterPanel.Height = Screen.PrimaryScreen.Bounds.Height - 95;
            ConfigPanel.Height = Screen.PrimaryScreen.Bounds.Height - 95;
            FilterPanel.Width = Screen.PrimaryScreen.Bounds.Width - 490;
            RegisterPanel.Width = Screen.PrimaryScreen.Bounds.Width - 470;
            LVMain.Width = RegisterPanel.Width;
            LVMain.Height = RegisterPanel.Height - 85;
            InfoPanel.Width = RegisterPanel.Width;
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
            SettingsForm vistaC = new SettingsForm();
            vistaC.ShowDialog();
        }


        #region Lectura y Modificación de Configuración
        private void BuildConfiguration() {

            

        }
        #endregion

        private void ListViewUpdateEvent(object sender, EventArgs e)
        {
            string tool = CbImportTool.Text;

            switch (tool)
            {
                case "Microsoft Excel":
                    ListViewUpdateExcel();
                    break;
                case "Microsoft Access":
                    /* PENDIENTE DE DESARROLLAR */
                    break;
                default:
                    MessageBoxHelper.GetQuestionMessageBox("Operación fallida", "Indique la tecnología de lectura de la fuente de datos.");
                    break;
            }
        }

        private void ListViewUpdateExcel() {

            MessageBoxHelper.GetExclamationMessageBox("Ruta", Path.Combine(DAdirectory,"Microsoft Excel", LVFormatRepoList.SelectedItems[0].Text));

            if (LVFormatRepoList.SelectedItems != null &&
                File.Exists(Path.Combine(DAdirectory,"Microsoft Excel",LVFormatRepoList.SelectedItems[0].Text)))
            {

                lvHelper = new ListViewHelper(
                    LVMain,
                    btNextPag,
                    btPrevPag,
                    TBPagination,
                    TBBatchAmmount,
                    Int32.Parse(TBBatchAmmount.Text),
                    Path.Combine(DAdirectory,"Microsoft Excel",LVFormatRepoList.SelectedItems[0].Text),
                    "ssc_mis_estudiantes_ss_00 (8)");
            }
            else {
                MessageBoxHelper.GetExclamationMessageBox("Error de operación", "Indique los siguientes datos para poder mostrar los registros, Tecnología a utilizar y archivo correspondiente.");
            }
        }

        private void ButtonImportFileEvent(object sender, EventArgs e)
        {
            if (CbImportTool.SelectedIndex > -1) {

                string tool = CbImportTool.Text;

                switch (tool)
                {
                    case "Microsoft Excel":
                        fileLocation = DialogResultHelper.OpenFileDialogFlow(tool);
                        break;
                    case "Microsoft Access":
                        /* PENDIENTE DE DESARROLLAR */
                        break;
                    default:
                        MessageBoxHelper.GetExclamationMessageBox("Operación fallida", "Indique la tecnología de lectura de la fuente de datos.");
                        break;
                }
            }
            else
            {
                MessageBoxHelper.GetExclamationMessageBox("Programa no indicado", "Seleccione un programa para la importación de datos deseada e intente de nuevo.");
            }

        }

        private void BTCreateDSEvent(object sender, EventArgs e)
        {
            if (CbImportTool.SelectedIndex > -1)
            {
                CreateDSView createDS = new CreateDSView(CbImportTool.Text);
                createDS.ShowDialog();
            }   
            else
            {
                MessageBoxHelper.GetExclamationMessageBox("Programa no indicado", "Seleccione un programa para la importación de datos deseada e intente de nuevo.");

            }
        }

        private void BTDeleteDS(object sender, EventArgs e)
        {
            if (CbImportTool.SelectedIndex > -1)
            {
                string tool = CbImportTool.Text;
                if (LVFormatRepoList.SelectedItems.Count > 0)
                {
                    string fileName = LVFormatRepoList.SelectedItems[0].Text;
                    string completeFile = Path.Combine(DAdirectory, $"{tool}\\{fileName}");

                    if (File.Exists(completeFile))
                    {
                        File.Delete(completeFile);
                        MessageBoxHelper.GetExclamationMessageBox("Operación correcta", "El archivo se ha borrado con éxito.");
                    }
                    else
                    {
                        MessageBoxHelper.GetExclamationMessageBox("Operación omitida", "El archivo no existe.");
                    }
                }
                else { 
                    MessageBoxHelper.GetExclamationMessageBox("Operación omitida", "No indicaste ningún archivo a eliminar.");
                }
            }
            else
            {
                MessageBoxHelper.GetExclamationMessageBox("Programa no indicado", "Seleccione un programa para la importación de datos deseada e intente de nuevo.");
            }
        }

        private void ButtonAddPaginationBatchClick(object sender, EventArgs e)
        {
            if (Int32.Parse(TBBatchAmmount.Text) < 99)
            {
                TBBatchAmmount.Text = (Int32.Parse(TBBatchAmmount.Text.ToString()) + 1).ToString();
            }
            else
            {
                MessageBoxHelper.GetExclamationMessageBox("Operación no valida", "Ya no se puede aumentar el lote deseado a más de 100 registros.");
            }
        }

        private void ButtonRemPaginationBatchClick(object sender, EventArgs e)
        {
            if (Int32.Parse(TBBatchAmmount.Text) > 1)
            {
                TBBatchAmmount.Text = (Int32.Parse(TBBatchAmmount.Text.ToString()) - 1).ToString();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PanelLogoClick(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void BtSettingsEvent(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        #region CBFileWatchers

        private void CBSelectedIndexChanged(object sender, EventArgs e)
        {
            LVFormatRepoList.Items.Clear();

            string selectedProgram = CbImportTool.SelectedItem.ToString();
            string directory =  Path.Combine(DAdirectory, selectedProgram);

            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

            string[] files = null;

            watcher.Path = directory;

            switch (selectedProgram)
            {
                case "Microsoft Access":
                    files = Directory.GetFiles(directory, "*.mdb");
                    break;
                case "Microsoft Excel":
                    files = Directory.GetFiles(directory, "*.xls");
                    break;
            }

            if (files != null)
            {
                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));
                    LVFormatRepoList.Items.Add(item);
                }
            }
        }

        private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            // Se llama cuando se modifica un archivo en el directorio
            ActualizarListView();
        }

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            // Se llama cuando se crea un archivo en el directorio
            ActualizarListView();
        }

        private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            // Se llama cuando se elimina un archivo en el directorio
            ActualizarListView();
        }

        private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            // Se llama cuando se renombra un archivo en el directorio
            ActualizarListView();
        }

        private void ActualizarListView()
        {
            if (CbImportTool.SelectedItem != null)
            {
                CBSelectedIndexChanged(null, null);
            }
        }


        #endregion

        #region GenerateDocs
        private void BtGenerateDocs(object sender, EventArgs e)
        {
            List<CSPrograma> selProgramas = new List<CSPrograma>();

            if (CbImportTool.SelectedIndex > -1 && 
                CBExportEngine.SelectedIndex > -1 &&
                CBTemplateEngine.SelectedIndex > -1 &&
                LVMain.Items != null &&
                LVMain.SelectedItems != null && 
                LVMain.SelectedItems.Count > 0)
            {

                switch (CbImportTool.Text) {
                      
                    case "Microsoft Excel":
                        List<CSMinExcelRowRecord> selRecords = lvHelper.ReturnSelRecordsExcel(LVMain);
                        selProgramas = CSExcelRowToGlobalClass.ProgramaExcelToObj(selRecords, null, null, null);
                        VistaProgreso prog = new VistaProgreso(selProgramas, CBExportEngine.Text, CBTemplateEngine.Text);
                        break;

                    case "Microsoft Access":

                        /* PENDIENTE DE DESARROLLAR */
                        break;
                }
                
            }
            else {
                MessageBoxHelper.GetExclamationMessageBox("Operación detenida", "Seleccione una herramienta de exportación para poder generar los documentos.");
            }
        }
        #endregion

        private void CBDocEditable_CheckedChanged(object sender, EventArgs e)
        {
            if (CBDocEditable.Checked)
            {

            }
        }

        private void CBAccessPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CBAccessPassword.Checked) {
                TBPassword.Enabled = true;
                TBPasswordConfirm.Enabled = true;
            }
            else
            {
                TBPassword.Enabled = false;
                TBPasswordConfirm.Enabled = false;
            }
        }

        private void CBEnableSendEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (CBEnableSendEmail.Checked)
            {
                CLBEmailOptions.Enabled = true;
            }
            else
            {
                CLBEmailOptions.Enabled = false;
            }
        }

        private void RBOnlyFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (RBOnlyFolder.Checked) { CBExportFilter.Enabled = false; }
        }

        private void RBSeparatedFolders_CheckedChanged(object sender, EventArgs e)
        {
            if (RBSeparatedFolders.Checked) { CBExportFilter.Enabled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}