using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;

namespace uanl_ss_lib_entities_api.GlobalEntities.Misc.Types
{
    public class IDBuilder<T>
    {
        public string BuildID(int numId)
        {
            string IDstr = string.Empty;  
            
            Type type = typeof(T);

            switch (type.GetType().Name)
            {
                case "CSEmpresa":
                    IDstr = $"EMP{numId}";
                    break;
                case "CSTipoEmpresa":
                    IDstr = $"TYE{numId}";
                    break;
                case "CSTipoAE":
                    IDstr = $"AEC{numId}";
                    break;
                case "CSDepEducativa":
                    IDstr = $"DPE{numId}";
                    break;
                case "CSDepartamento":
                    IDstr = $"DEP{numId}";
                    break;
                case "CSTipoPrograma":
                    IDstr = $"TYP{numId}";
                    break;
                case "CSComunidad":
                    IDstr = $"COM{numId}";
                    break;
                case "CSResponsable":
                    IDstr = $"RSP{numId}";
                    break;
                case "CSCoordinador":
                    IDstr = $"CRD{numId}";
                    break;
                case "CSAlumno":
                    IDstr = $"ALM{numId}";
                    break;
                case "CSTurno":
                    IDstr = $"TRN{numId}";
                    break;
                case "CSActividad":
                    IDstr = $"ACT{numId}";
                    break;
                case "CSPeriodo":
                    IDstr = $"PRD{numId}";
                    break;
                case "CSCarrera":
                    IDstr = $"CAR{numId}";
                    break;
            }

            return IDstr;

        }
       
    }
}
