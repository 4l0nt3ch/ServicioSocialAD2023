using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_office_excel_local_api.MinimalAdapterClass
{
    public class CSMinExcelRowRecord
    {
        public CSMinEstudiante estudiante { get; set; }
        public CSMinEmpresa empresa { get; set; }
        public CSMinPrograma programa { get; set; }
        public CSMinExcelRowRecord() { }

        public CSMinExcelRowRecord(CSMinEstudiante estudiante, CSMinEmpresa empresa, CSMinPrograma programa)
        {
            this.estudiante = estudiante;
            this.empresa = empresa;
            this.programa = programa;
        }

       

    }
}
