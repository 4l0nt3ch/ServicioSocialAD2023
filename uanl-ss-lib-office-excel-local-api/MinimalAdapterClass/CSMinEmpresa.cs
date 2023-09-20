using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;

namespace uanl_ss_lib_office_excel_local_api.MinimalAdapterClass
{
    public class CSMinEmpresa
    {
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
        public string Tipo { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string EmpresaTamaño { get; set; }
        public string TpActEcono { get; set; }

        public CSMinEmpresa() { }

        public CSMinEmpresa(string razonSocial, string rFC, string tipo, string pais,
            string estado, string ciudad, string empresaTamaño, string tpActEcono)
        {
            RazonSocial = razonSocial;
            RFC = rFC;
            Tipo = tipo;
            Pais = pais;
            Estado = estado;
            Ciudad = ciudad;
            EmpresaTamaño = empresaTamaño;
            TpActEcono = tpActEcono;
        }
    }
}
