using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_office_word_local_api.Service;
using Word = Microsoft.Office.Interop.Word;

namespace uanl_ss_lib_office_word_local_api.MinimalAdapterClass
{
    public class CSWdTabla
    {
        private Document Documento { get; set; }
        private WdTextOrientation Orientation { get; set; }
        private string Family { get; set; }
        private float FontSize { get; set; }
        private string[,] TextosTabla { get; set; }
        private Table Tabla { get; set; } 
        public float FormaIzquierda { get; set; }
        public float FormaArriba { get; set; }
        private int NumeroDeFilas { get; set; }
        private int NumeroDeColumnas { get; set; }

        public CSWdTabla(Document document, WdTextOrientation orientation, 
            string family, float fontSize, string[,] textosTabla,
            float formaIzq, float formaArr) {
            Orientation = orientation;
            Family = family;
            FontSize = fontSize;
            Documento = document;
            TextosTabla = textosTabla;
            FormaIzquierda = formaIzq;
            FormaArriba = formaArr;
            NumeroDeFilas = TextosTabla.GetLength(0);
            NumeroDeColumnas = TextosTabla.GetLength(1);
        }

        public CSWdTabla() { }

        public Table WdCreateTable(float inchesTop, float inchesLeft) {
            Word.Range wholeDocumentRange = Documento.Content;
            
            Tabla = Documento.Tables.Add(
                    wholeDocumentRange,
                    NumeroDeFilas,
                    NumeroDeColumnas
                );

            for (int i = 0; i < NumeroDeFilas; i++)
            {
                for (int j = 0; j < NumeroDeColumnas; j++)
                {
                    Tabla.Rows[NumeroDeFilas + 1]
                        .Cells[NumeroDeColumnas + 1]
                        .Range.Text = TextosTabla[i, j];
                }
            }

            foreach (Word.Cell cell in Tabla.Range.Cells) {
                Word.Range cellRange = cell.Range;

                cellRange.Font.Name = Family;
                cellRange.Font.Size = FontSize;
                cellRange.Orientation = Orientation;
            }

            return Tabla;
        }
    }
}
