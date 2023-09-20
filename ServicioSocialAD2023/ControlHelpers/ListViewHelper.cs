using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uanl_ss_lib_office_excel_local_api;
using uanl_ss_lib_office_excel_local_api.MinimalAdapterClass;
using uanl_ss_lib_office_excel_local_api.Repositories;

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
        private RepositorioExcel repoExcel { get; set; }
        public List<CSMinExcelRowRecord> recordList { get; set; }
        public List<CSMinExcelRowRecord> paginatedList { get; set; }

        public ListViewHelper(ListView view, Button btnSiguiente, Button btnAtras, TextBox tbPagination, TextBox tbBatch,
            int itemsPerPage, string rutaArchivo, string hojaCalculo)
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

            recordList = new List<CSMinExcelRowRecord>();
            repoExcel = new RepositorioExcel(rutaArchivo, hojaCalculo, tbBatch.Text);

            recordList = repoExcel.ExcelRecords;
            UpdateListView();
        }

        public void UpdateListView() {
            int startIndex = (currentPage - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, recordList.Count);

            paginatedList = recordList.GetRange(startIndex, endIndex - startIndex);

            listView.Items.Clear();

            foreach (CSMinExcelRowRecord obj in paginatedList) {
                ListViewItem item = new ListViewItem(obj.estudiante.Matricula);
                item.SubItems.Add(obj.estudiante.Nombre);
                item.SubItems.Add(obj.estudiante.APaterno);
                item.SubItems.Add(obj.estudiante.AMaterno);
                item.SubItems.Add(obj.estudiante.CarreaAbrev);
                item.SubItems.Add(obj.empresa.RazonSocial);
                item.SubItems.Add(obj.empresa.TpActEcono);
                item.SubItems.Add(obj.programa.Descripcion);
                item.SubItems.Add(obj.programa.Deparatmento);
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
