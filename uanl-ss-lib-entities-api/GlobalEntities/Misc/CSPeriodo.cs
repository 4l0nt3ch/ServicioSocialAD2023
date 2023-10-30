using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_entities_api.GlobalEntities.Misc
{
    public class CSPeriodo
    {
        public string ID {  get; set; }
        public string Descripcion { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public DateTime FechaAceptacion { get; set; }
        public DateTime[] FechaEvaluaciones { get; set; }
        public CSPeriodo() { }
        public CSPeriodo(string iD, string descripcion, DateOnly fechaInicio, DateOnly fechaFin,
            DateTime fechaAceptacion, DateTime[] fechaEvaluaciones)
        {
            ID = iD;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            FechaAceptacion = fechaAceptacion;
            FechaEvaluaciones = fechaEvaluaciones;
        }
    }
}
