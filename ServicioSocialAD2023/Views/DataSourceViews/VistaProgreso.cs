using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using uanl_ss_main_ui.ControlHelpers;

namespace uanl_ss_main_ui
{
    public partial class VistaProgreso : Form
    {
        List<CSPrograma> LSProgramas { get; set; }
        CancellationTokenSource CTSource { get; set; }
        private string ExportTool { get; set; }
        private string Template { get; set; }
        private string arrangeType { get; set; }    
        public VistaProgreso(List<CSPrograma> listProgramas, string ExportTool, string Template, string arrangeType)
        {
            InitializeComponent();
            this.ExportTool = ExportTool;
            this.Template = Template;
            this.LSProgramas = listProgramas;
            this.arrangeType = arrangeType;
            CheckForIllegalCrossThreadCalls = false;
            ShowDialog();
        }

        private void ButtonCancelClicked(object sender, EventArgs e)
        {
            if (CTSource != null) {
                CTSource.Cancel();
            }
        }

        private void VistaProgresoLoad(object sender, EventArgs e)
        {
            try
            {
                switch (ExportTool)
                {
                    case "Microsoft Word":
                        WordExportTool();
                        break;
                    case "Aspose PDF":
                        PDFExportTool();
                        break;
                    default:
                        MessageBoxHelper.GetExclamationMessageBox("Operacion Fallida", "No se indico ninguna herramienta de exportación.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la generación de las boletas, ex." + ex.Message,
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void WordExportTool()
        {
            CTSource = new CancellationTokenSource();
            switch (Template)
            {
                case "Boleta de Presentación":               
                    await TaskHelper.GenerateBPTask(this, LSProgramas, CTSource, arrangeType);
                    break;
                case "Carta de Inicio":
                    await TaskHelper.GenerateCITask(this, LSProgramas, CTSource, arrangeType);
                    break;
                case "Kardex":
                    break;
                default:
                    break;
            }
        }

        private async void PDFExportTool()
        {
            CTSource = new CancellationTokenSource();
            switch (Template)
            {
                case "Boleta de Presentación":
                    break;
                case "Carta de Inicio":
                    break;
                case "Kardex":
                    break;
                default:
                    break;
            }
        }
    }
}
