using Word = Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office = Microsoft.Office.Core;

namespace uanl_ss_lib_office_word_local_api.MinimalAdapterClass
{
    public class CSWdTexto
    {
        private Word.Document Documento { get; set; }
        private Word.WdTextOrientation Orientation { get; set; }
        private Word.Shape FormaTexto { get; set; }
        private string Family { get; set; }
        private float FontSize { get; set; }
        private string Contenido { get; set; }
        private float FormaIzquierda { get; set; }
        private float FormaArriba { get; set; }
        private float FormaAlto { get; set; }
        private float FormaAncho { get; set; }

        public CSWdTexto(Word.Document document, string contenido, float formaIzq,
            float formaArriba, float formaAlto, float formaAncho)
        {
            Documento = document;
            Contenido = contenido;
            FormaIzquierda = formaIzq;
            FormaArriba = formaArriba;
            FormaAlto = formaAlto;
            FormaAncho = formaAncho;
        }

        public CSWdTexto() { }

        public Word.Shape WdCreateText() {
            Word.Range wholeDocumentRange = this.Documento.Content;

            FormaTexto = Documento.Shapes.AddShape(
                (int) Office.MsoAutoShapeType.msoShapeRectangle,
                FormaIzquierda,
                FormaArriba,
                FormaAncho,
                FormaAlto,
                wholeDocumentRange
                );

            Word.TextFrame textFrame = FormaTexto.TextFrame;
            textFrame.TextRange.Text = Contenido;

            Word.Range text = textFrame.TextRange;
            text.Font.Name = Family;
            text.Font.Size = FontSize;

            text.Orientation = Orientation;

            return FormaTexto;          
        }



    }
}
