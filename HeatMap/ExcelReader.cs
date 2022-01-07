using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using LinqToExcel;

namespace HeatMap
{
    
    class ExcelReader
    {        
        public string filename;
        public Data[] data;

        public ExcelReader()
        {
            filename = openFile("Open SAP spreadsheet");
            OpenExcel(filename);
        }

        private string openFile(string title)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = title;
            fileOpen.ShowDialog();
            return fileOpen.FileName;
        }

        private void OpenExcel(string filePath)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            string[] IDs = new string[rowCount];

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            
            for (int i = 2; i <= rowCount; i++)
            {
                //write the value to the console
                if (xlRange.Cells[i, 7].value2 != null)
                {
                    IDs[i - 2] = xlRange.Cells[i, 7].value2.ToString();

                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);         

            IEnumerable<string> uniqueItems = IDs.Distinct<string>();

            data = new Data[uniqueItems.Count() - 1];
            int index = 0;
            foreach (string s in uniqueItems)
            {
                if (s != null)
                {
                    data[index] = new Data(s, 0);
                    index++;
                }
            }

            
            for (int i = 0; i < IDs.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if (IDs[i] != null)
                    {
                        if (IDs[i].Equals(data[j].StringData))
                        {                                                 
                            data[j].Update();
                        }
                    }
                }                
            }
        }
    }

    class Data
    {
        public string StringData;
        public int IntData;
        public Data(string strValue, int intValue)
        {
            StringData = strValue;
            IntData = intValue;
        }

        public void Update()
        {
            IntData++;
        }
    }
}
