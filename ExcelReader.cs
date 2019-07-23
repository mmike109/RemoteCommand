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

                i++;
                j++;

            while (true)
            {
                if (ws.Cells[i, j].Value2 != null)
                {
                    return
                        ws.Cells[i, j].Value2;
                }

            }
          
        }


        public int RowCount(int i, int j)
        {
            i++;
            j++;


            if(ws.Cells[i, j].Value2 != null)
                 return ws.Rows.Count;
            else
            {
                return 0 ;
            }
        }
        

        
    }
}
