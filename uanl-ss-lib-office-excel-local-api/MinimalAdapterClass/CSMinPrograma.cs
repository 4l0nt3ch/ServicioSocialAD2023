using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_office_excel_local_api.MinimalAdapterClass
{
    public class CSMinPrograma
    {
        public string Deparatmento { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string ComuniadAtend { get; set; }
        public string Responsable { get; set; }
        public string Turno { get; set; }
        public string Beca { get; set; }
        public string Actividad { get; set; }

        public CSMinPrograma() { }

        public CSMinPrograma(string deparatmento, string descripcion, string tipo, string comuniadAtend,
            string responsable, string turno, string beca, string actividad)
        {
            Deparatmento = deparatmento;
            Descripcion = descripcion;
            Tipo = tipo;
            ComuniadAtend = comuniadAtend;
            Responsable = responsable;
            Turno = turno;
            Beca = beca;
            Actividad = actividad;
        }
    }
}
