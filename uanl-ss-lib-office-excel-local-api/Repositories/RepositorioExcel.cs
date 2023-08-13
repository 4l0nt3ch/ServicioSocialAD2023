using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using uanl_ss_lib_office_excel_local_api.MinimalAdapterClass;

namespace uanl_ss_lib_office_excel_local_api.Repositories
{
    public class RepositorioExcel
    {
        private ExcelService service { get; set; }
        public List<CSMinExcelRowRecord> ExcelRecords { get; set; }

        public RepositorioExcel(string filePath, string worksheet, string batch)
        {
            service = new ExcelService(filePath,worksheet, batch);
            ExcelRecords = GetCSMinExcelRowRecords();
        }

        private List<CSMinExcelRowRecord> GetCSMinExcelRowRecords() {
            ExcelRecords = new List<CSMinExcelRowRecord>();

            List<CSMinEstudiante> LSEstudiantes = GetCSMinEstudiante();
            List<CSMinEmpresa> LSEmpresas = GetCSMinEmpresa();
            List<CSMinPrograma> LSProgramas = GetCSMinPrograma();

            service.ExcelShutdown();

            if (LSEmpresas.Count == LSEstudiantes.Count && 
                LSProgramas.Count == LSEstudiantes.Count)
            {
                for (int i = 0; i < LSEstudiantes.Count; i++)
                {
                    ExcelRecords.Add(new CSMinExcelRowRecord(
                        LSEstudiantes[i], LSEmpresas[i], LSProgramas[i]
                        ));
                }
            }

            return ExcelRecords;
        }

        private List<CSMinEstudiante> GetCSMinEstudiante()
        {
            return service.GetTypeList<CSMinEstudiante>(7, "A:K");
        }

        private List<CSMinEmpresa> GetCSMinEmpresa()
        {
            return service.GetTypeList<CSMinEmpresa>(7, "L:S");
        }

        private List<CSMinPrograma> GetCSMinPrograma()
        {
            return service.GetTypeList<CSMinPrograma>(7, "T:AA");
        }
    }   
}
