using Word = Microsoft.Office.Interop.Word;

namespace uanl_ss_lib_office_word_local_api.MinimalAdapterClass
{
    public class CSWdImagen
    {
        private Word.Document Documento { get; set; }
        private string Contenido { get; set; }
        private Word.Shape Forma {get; set; }
        private float FormaIzquierda { get; set; }
        private float FormaArriba { get; set; }
        private float FormaAlto { get; set; }
        private float FormaAncho { get; set; }

        public CSWdImagen(Word.Document document, string content, 
            float left, float top, float width, float height)
        {
            this.Documento = document;
            this.Contenido = content;
            this.FormaIzquierda = left;
            this.FormaArriba = top;
            this.FormaAlto = height;
            this.FormaAncho = width;
        }

        public CSWdImagen() { }

        public Word.Shape WdCreateImage() {
            Word.Range wholeDocumentRange = this.Documento.Content;
            this.Forma = Documento.Shapes.AddPicture(
                Contenido,
                Type.Missing,
                Type.Missing,
                FormaIzquierda,
                FormaArriba,
                FormaAncho,
                FormaAlto,
                wholeDocumentRange);

            return Forma;
        }
    }
}
