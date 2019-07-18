using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace RemoteCommand
{
    class ExcelReader
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public ExcelReader(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }
        
        public string ReadCell(int i , int j)
        { 
            //for( i = 1; i< 100;i++)
            //{
                i++;
                j++;
            //}
           

            if (ws.Cells[i, j].Value2 != null)
                return 
                    ws.Cells[i, j].Value2;
            else {
                return "";
            }
        }


        public int RowCount(int i, int j)
        {
            i++;
            j++;


            if((int)ws.Cells[i, j].Value2 != 0)
                 return ws.Rows.Count;
            else
            {
                return 0 ;
            }
        }
        

        
    }
}
