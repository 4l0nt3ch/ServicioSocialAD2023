using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace uanl_ss_lib_office_excel_local_api.Helpers
{
    public class StringHelpers
    {
        public static string SHValidateExcelString(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return string.Empty;
            }
            else
            {
                return cadena;
            }
        }

        public static string GetAcronym(string cadena)
        {
            string patron = @"\w+\.";


            List<string> list = new List<string>();
            MatchCollection coincidencias = Regex.Matches(cadena, patron);

            foreach (Match coincidencia in coincidencias)
            {
                Console.WriteLine(coincidencia.Value);
                list.Add(coincidencia.Value.ToString());
            }

            return string.Join("",list);
        }

        public static string FullName(string cadena)
        {
            string patron = @"\b(?![A-Za-záéíóúÁÉÍÓÚ]+\.)[A-Za-záéíóúÁÉÍÓÚ]+\b";

            List<string> list = new List<string>();
            MatchCollection coincidencias = Regex.Matches(cadena, patron);

            foreach (Match coincidencia in coincidencias)
            {
                Console.WriteLine(coincidencia.Value);
                list.Add(coincidencia.Value.ToString());
            }

            return string.Join(" ", list);
        }

        public static string[] SHValidateAndDivideExcelString(string cadena)
        {
            if (cadena != null && cadena != string.Empty)
            {
                string[] values = new string[] { GetAcronym(cadena) };
                string[] values2 = FullName(cadena).Split(" ");

                values = values.Concat(values2).ToArray();

                return values;
            }
            else
            {
                return Array.Empty<string>();
            }
        }


    }
}
