using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace uanl_ss_lib_office_excel_local_api 
{
    public class ExcelService
    {
        private Excel.Application XlApp { get; set; }
        private Workbook XlWorkbook { get; set; }
        private Worksheet XlWorksheet { get; set; }
        private int batchSize { get; set; }

        public ExcelService(string excelFile, string excelWs, string batchSize) {
            XlApp = GetExcelInstance();
            XlWorkbook = (Workbook)XlApp.Workbooks.Open(excelFile);
            XlWorksheet = (Worksheet)XlWorkbook.Sheets[excelWs];
            this.batchSize = Int32.Parse(batchSize);
        }

        private Excel.Application GetExcelInstance() {
            if (XlApp == null)
            {
                XlApp = new Excel.Application();
                return XlApp;
            }
            else {
                return XlApp;
            }
        }

        public void ExcelShutdown() {

            if (XlWorksheet != null) {
                Marshal.ReleaseComObject(XlWorksheet);
                XlWorksheet = null;
            }
            if (XlWorkbook != null)
            {
                XlWorkbook.Close();
                Marshal.ReleaseComObject(XlWorkbook);
                XlWorkbook = null;
            }
            if (XlApp != null)
            {
                XlApp.Quit();
                Marshal.ReleaseComObject(XlApp);
                XlApp = null;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void LiberateMemoryRange(Excel.Range range) {
            while (range != null)
            {
                Marshal.ReleaseComObject(range);
                range = null;
            }
        }

        public List<T> GetTypeList<T>(int filaInicial, string rangoColumnas) where T : new()
        {
            try
            {
                List<T> list = new List<T>();
                object[,] excelData = GetValueRanges(filaInicial, rangoColumnas);

                if (excelData != null)
                {
                    int rowCount = excelData.GetLength(0);
                    int colCount = excelData.GetLength(1);

                    PropertyInfo[] properties = typeof(T).GetProperties();

                    for (int row = 0; row < rowCount; row++)
                    {
                        T obj = new T();

                        for (int col = 0; col < colCount; col++)
                        {
                            object value = excelData[row + 1, col + 1];

                            PropertyInfo property = properties[col];

                            if (value != null)
                            {
                                if (value.GetType() == typeof(string))
                                {
                                    property.SetValue(obj, value);
                                }
                                else
                                {
                                    property.SetValue(obj, value.ToString());
                                }
                            }
                            else
                            {
                                property.SetValue(obj, null);
                            }
                        }

                        list.Add(obj);
                    }
                }
                return list;
            }
            catch (NullReferenceException ex) {
                MessageBox.Show(ex.Message + " at " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<T>();
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message + " at " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<T>();
            }
        }

        private Excel.Range ReturnRange(string rangoColumnas, string rangoFilas) {
            string[] columns = rangoColumnas.Split(":");
            string[] filas = rangoFilas.Split(":");

            string stCell = columns[0] + filas[0];
            string endCell = columns[1] + filas[1];

            return XlWorksheet.Range[stCell, endCell];
        }

        private object[,] GetValueRanges(int filaInicial, string rangoColumnas) {
            try
            {
                XlWorksheet.Activate();

                Excel.Range usedRange = XlWorksheet.UsedRange;
                Excel.Range rows = usedRange.Rows;
                int ultimaFila = rows.Count;
                int filaActual = filaInicial;

                LiberateMemoryRange(usedRange);
                LiberateMemoryRange(rows);

                string rangoFilas = $"{filaInicial}:{ultimaFila - 1}";
                Excel.Range infoRange = ReturnRange(rangoColumnas, rangoFilas);
                infoRange.Select();

                object[,] finalValues = (object[,]) infoRange.Value;

                LiberateMemoryRange(infoRange);

                return finalValues;
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message +  " at " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }
    }
}