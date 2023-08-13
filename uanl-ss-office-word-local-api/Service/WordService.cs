using System.Runtime.InteropServices;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using uanl_ss_lib_office_word_local_api.MinimalAdapterClass;
using Word = Microsoft.Office.Interop.Word;

namespace uanl_ss_lib_office_word_local_api.Service
{
    public class WordService
    {
        private Word.Application WdApplication { get; set; }
        private string WdExportLocation { get; set; }
        private string WdExportFilter { get; set; }
        private Word.Document WdDocument {get; set;}
        private CSPrograma WdPrograma { get; set; }
         
        public WordService() {
            WdApplication = WdInitialize();
        }

        public Word.Application WdInitialize() {
            if (WdApplication.Application == null)
            {
                return new Word.Application() { Visible = false };
            }
            else {
                return WdApplication;
            }
        }

        public void MoveCursorToPositionInPoints(Word.Shape currentShape, 
            float topInches, float leftInches)
        {
            if (WdApplication != null) {
                float leftPoints = WdApplication.InchesToPoints(leftInches);
                float topPoints = WdApplication.InchesToPoints(topInches);

                currentShape.Left = leftPoints;
                currentShape.Top = topPoints;
            }
            
        }

        public void WdShutdown() {
            if (WdApplication != null) {
                WdApplication.Quit();
                Marshal.ReleaseComObject(WdApplication);
                WdApplication = null;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public Word.Document WdOpenNewFile() {
            if (WdDocument != null) {
                while (WdDocument != null)
                {
                    WdCloseFile();
                }
                WdDocument = WdApplication.Documents.Add();
                return WdDocument;
            }
            else
            {
                WdDocument = WdApplication.Documents.Add();
                return WdDocument;
            }
        }

        public CSWdTexto WdWriteParagraph(string contenido, float left,
            float top, float width, float height) {

            return new CSWdTexto(
                WdDocument,
                contenido,
                left,
                top,
                width,
                height
                );
        }

        public CSWdTabla WdWriteTable(Word.WdTextOrientation orientation, 
            string family, float fontSize, string[,] textosTabla,
            float left, float top) {

            return new CSWdTabla(
                WdDocument,
                orientation,
                family,
                fontSize,
                textosTabla,
                left,
                top
                );
        }

        public CSWdImagen WdWriteImage(string contenido, float left,
            float top, float width, float height) {

            return new CSWdImagen(
                WdDocument,
                contenido,
                left,
                top,
                width,
                height
                );
        }

        public void WdSaveFile(string WdInternalFP)
        {
            WdDocument.SaveAs2(
                Path.Combine(WdExportLocation, WdInternalFP),
                Word.WdSaveFormat.wdFormatDocument);
        }

        public void WdCloseFile() {
            if (WdDocument != null) {
                WdDocument.Close();
                Marshal.ReleaseComObject(WdDocument);
                WdDocument = null;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
