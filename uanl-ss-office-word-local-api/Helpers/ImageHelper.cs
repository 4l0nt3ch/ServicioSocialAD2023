using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;

namespace uanl_ss_lib_office_word_local_api.Helpers
{
    public class ImageHelper
    {
        public static void imageShape(string shapeName, Word.Document document, String imgSource, float left, float top, float width, float height)
        {

            Word.Shape shpCanvas = document.Shapes[shapeName];

            Word.Shape shpImage = shpCanvas.CanvasItems.AddPicture(
                imgSource, LinkToFile: false, SaveWithDocument: true,
                left,
                top,
                width,
                height
                );
        }
    }
}
