using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using uanl_ss_lib_entities_api.GlobalEntities.Misc;
using uanl_ss_lib_entities_api.GlobalEntities.Roles;
using uanl_ss_lib_office_excel_local_api.MinimalAdapterClass;
using uanl_ss_lib_office_excel_local_api.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace uanl_ss_main_ui.ControlHelpers
{
    public class ListViewHelper
    {
        public Button btnSiguiente { get; set; }
        public Button btnAtras { get; set; }
        public TextBox tbPagination { get; set; }
        public TextBox tbBatch { get; set; }
        public ListView listView { get; set; }
        public int itemsPerPage { get; set; }
        public int currentPage { get; set; }
        public string rutaArchivo { get; set; }
        public string hojaCalculo { get; set; }
        public string format { get; set; }
        private RepositorioExcel repoExcel { get; set; }
        public List<CSMinExcelRowRecord> recordList { get; set; }
        public List<CSMinExcelRowRecord> paginatedList { get; set; }
        public List<CSPrograma> pagProg { get; set; }

        public ListViewHelper(ListView view, Button btnSiguiente, Button btnAtras, TextBox tbPagination, TextBox tbBatch,
            int itemsPerPage, string rutaArchivo, string hojaCalculo, string format)
        {
            this.listView = view;
            this.btnSiguiente = btnSiguiente;
            this.btnAtras = btnAtras;
            this.tbPagination = tbPagination;
            this.tbBatch = tbBatch;
            this.itemsPerPage = itemsPerPage;
            this.currentPage = 1;
            this.rutaArchivo = rutaArchivo;
            this.hojaCalculo = hojaCalculo;
            this.format = format;

            recordList = new List<CSMinExcelRowRecord>();
            repoExcel = new RepositorioExcel(rutaArchivo, hojaCalculo, tbBatch.Text);

            recordList = repoExcel.ExcelRecords;
            UpdateListView("Excel",null,null,null);
        }

        public void UpdateListView(string? sourceTool, CSDepEducativa? CSed, CSCoordinador? CSCoord, CSPeriodo? CSPer) {
            int startIndex = (currentPage - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, recordList.Count);

            paginatedList = recordList.GetRange(startIndex, endIndex - startIndex);
            listView.Items.Clear();

            pagProg = null;

            if (sourceTool == null || sourceTool == "Excel")
            {
                pagProg = CSExcelRowToGlobalClass.ProgramaExcelToObj(paginatedList,CSed,CSCoord,CSPer);
            }
            else if (sourceTool == "Access")
            {
                pagProg = null;
            }
            
            foreach (CSPrograma obj in pagProg) {
                ListViewItem item = new ListViewItem(obj.Alumno.Matricula);
                item.SubItems.Add(
                    FileAccessHelper.CheckFileExistence(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "UANL Servicio Social", "Archives" , "BPSS")
                    , obj, format
                    ));
                item.SubItems.Add(
                    FileAccessHelper.CheckFileExistence(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "UANL Servicio Social", "Archives", "CISS")
                    , obj, format
                    ));
                item.SubItems.Add(
                    FileAccessHelper.CheckFileExistence(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "UANL Servicio Social","Archives", "KRD")
                    , obj, format
                    ));
                item.SubItems.Add(obj.Alumno.Nombre);
                item.SubItems.Add(obj.Alumno.ApellidoPaterno);
                item.SubItems.Add(obj.Alumno.ApellidoMaterno);
                item.SubItems.Add(obj.Alumno.Carrera.Abreviacion);
                item.SubItems.Add(obj.Empresa.RazonSocial);
                item.SubItems.Add(obj.Empresa.ActividadEconomica.Descripcion);
                item.SubItems.Add(obj.Descripcion);
                item.SubItems.Add(obj.Departamento.Departamento);
                listView.Items.Add(item);
            }

            tbPagination.Text = $"{currentPage} de {Math.Ceiling((double)recordList.Count / itemsPerPage)}";
        }

        public List<CSMinExcelRowRecord> ReturnSelRecordsExcel(ListView view) { 
            
            List<CSMinExcelRowRecord> selectedRows = new List<CSMinExcelRowRecord>();

            if (view.Items.Count > 0 && view.SelectedItems.Count > 0
                && recordList != null && recordList.Count > 0) {

                foreach (ListViewItem item in view.SelectedItems)
                {

                    string valRef = item.SubItems[0].Text;

                    CSMinExcelRowRecord record = recordList.FirstOrDefault(obj => obj.estudiante.Matricula == valRef);

                    if (record != null)
                    {
                        selectedRows.Add(record);
                    }

                }
            }
            
            return selectedRows;

        }

    }
}
