using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies.Types;

namespace uanl_ss_lib_entities_api.GlobalEntities.Dependencies
{
    public class CSEmpresa
    {
        public string ID { get; set; }
        public string RazonSocial { get; set; }
        public CSTipoEmpresa Tipo { get; set; }
        public string RFC { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string TamañoEmpresa { get; set; }
        public CSTipoAE ActividadEconomica { get; set; }
        public CSEmpresa() { }
        public CSEmpresa(string id, string razonSocial, CSTipoEmpresa tipo, string rFC, string pais, 
            string estado, string ciudad, string tamañoEmpresa, CSTipoAE actividadEconomica)
        {
            ID = id;
            RazonSocial = razonSocial;
            RFC = rFC;
            Tipo = tipo;
            Pais = pais;
            Estado = estado;
            Ciudad = ciudad;
            TamañoEmpresa = tamañoEmpresa;
            ActividadEconomica = actividadEconomica;
        }
    }
}
