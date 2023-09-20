using Microsoft.Office.Interop.Word;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using Word = Microsoft.Office.Interop.Word;

namespace uanl_ss_lib_office_word_local_api.Service
{
    public class WordService
    {
        private Word.Application WdApplication { get; set; }
        private Word.Document WdDocument {get; set;}
         
        public WordService() {
            WdApplication = WdInitialize();
        }

        public Word.Application WdInitialize() {
            if (WdApplication == null)
            {
                return new Word.Application() { Visible = false };
            }
            else {
                return WdApplication;
            }
        }

        public Word.Document WdOpenTmplFile(string file, string password)
        {
            Assembly asm  = Assembly.GetExecutingAssembly();

            string asmLoc = asm.Location;
            string asmPath = Path.GetDirectoryName(asmLoc);
            string filePath = Path.Combine(asmPath, file);


            if (File.Exists(filePath))
            {

                WdDocument = WdApplication.Documents.Open(
                    filePath, PasswordDocument: password);

                return WdDocument;
            }
            else
            {
                return WdApplication.Documents.Add();
            }
                
        }

        public void WdReplaceTextSingle(Word.Document doc,
            string oldText,
            string newText)
        {

            foreach (Word.Range r in doc.StoryRanges)
            {
                string textToSearch = r.Text;
                int startIndex = textToSearch.IndexOf(oldText);

                if (textToSearch.Contains(oldText)) {

                    int endIndex = startIndex + oldText.Length;

                    string textBefore = textToSearch.Substring(0, startIndex);
                    string textToReplace = textToSearch.Substring(startIndex, oldText.Length);
                    string textAfter = textToSearch.Substring(endIndex);
                    
                    string newTextReplaced = textBefore + newText + textAfter;
                    r.Text = newTextReplaced;

                    startIndex = textToSearch.IndexOf(oldText, endIndex);
                }
            }
        }

        public void WdFindReplaceText(string prevValue, string postValue)
        {
            WdDocument.Range().Find.ClearFormatting();
            WdDocument.Range().Find.Replacement.ClearFormatting();

            Find find = WdDocument.Range().Find;
            find.Text = prevValue;
            find.Replacement.Text = postValue;
            find.Forward = true;
            find.Wrap = WdFindWrap.wdFindContinue;
            find.Format = false;
            find.MatchCase = false;
            find.MatchWholeWord = false;
            find.MatchWildcards = false;
            find.MatchSoundsLike = false;
            find.MatchAllWordForms = false;

            find.Execute(Replace: WdReplace.wdReplaceAll);
        }

        public void WdReplaceTextInTableColumn(string[] newText)
        {
            if (WdDocument.Tables.Count >= 1)
            {
                Table table = WdDocument.Tables[1];

                int columnIndex = 2;

                for (int i = 0; i < newText.Length; i++)
                {
                    Cell cell = table.Cell(i + 1, columnIndex);
                    cell.Range.Text = newText[i];

                    Marshal.ReleaseComObject(cell);
                }
                Marshal.ReleaseComObject(table);
            }
        }

        public void WdSaveFileAs(string WdInternalFP)
        {
            WdDocument.SaveAs2(
                WdInternalFP, WdSaveFormat.wdFormatDocumentDefault);
        }

        public void WdSaveFile()
        {
            WdDocument.Save();
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

        public void WdShutdown()
        {
            if (WdApplication != null)
            {
                WdApplication.Quit();
                Marshal.ReleaseComObject(WdApplication);
                WdApplication = null;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /* FRAGMENTO RAMA LUIS SANDOVAL WORD TO PDF */

        public void WdConvertToPdf(string outputFilePath)
        {
            WdDocument.ExportAsFixedFormat(outputFilePath, WdExportFormat.wdExportFormatPDF);
            WdCloseFile();
        }
    }
}
