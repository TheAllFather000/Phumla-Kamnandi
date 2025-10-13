using Microsoft.Office.Interop.Excel;
using Phumla.Data;
using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Phumla.Business
{
    public class SummaryReport
    {
        private PaymentDB payments;
        static string[] headers = { "Jan", "Feb", "Mar", "Apr" , "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec", "TOTAL"};
        static string[] hotels = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD" };
        Range range = null;
        public void GenerateSummaryReport()
        {
            Excel.Application application = new Excel.Application();
            application.Visible = true;

            Excel.Workbook workbook = application.Workbooks.Add(); //creating excel file
            Excel.Worksheet sheet = (Excel.Worksheet) workbook.Worksheets.Add(); //creating sheet.
            Excel.Range phumlakTitle = sheet.get_Range("A1", "F1"); //getting the top section for the header.
            //making the headers and note
            phumlakTitle.Merge();
            phumlakTitle.Value = "Phumla Kamnandi: Summary Report Of "+DateTime.Now.Year;
            phumlakTitle.Font.Bold = true;
            phumlakTitle.Font.Size = 14;
            phumlakTitle.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            phumlakTitle.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            phumlakTitle.Font.Color = System.Drawing.Color.Black;

            application.ActiveWindow.DisplayGridlines = true;
            //note cell
            sheet.Cells[2, 1] = "NB: All values displayed below are in millions of Rand ©";
            Excel.Range noteRange = sheet.get_Range("A2", "E2");

            noteRange.Merge();
            noteRange.Font.Italic = true;
            noteRange.Font.Size = 10;
            noteRange.Font.Color= System.Drawing.Color.Black;

            sheet.Columns["A:D"].AutoFit();

            for(int i = 0; i < headers.Length; i++)
            {
                sheet.Cells[4, i+1] = headers[i];
            }
            
            Excel.Range headerRange = sheet.Range["A4", "M4"];
            headerRange.Font.Bold = true;
            headerRange.Font.Size = 10;
            
            headerRange.Interior.Color = ColorTranslator.ToOle(Color.DarkGreen);
            headerRange.Font.Color = System.Drawing.Color.White;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            int aaaaah = 0;
            for (int  i = 0; i < hotels.Length; i++)
            {
                sheet.Cells[5 + i, 1] = "Hotel "+hotels[i];
                range = sheet.Range["A"+(5+i), "M"+(5+i)];
                if (i % 2 == 1)
                    range.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
                else
                    range.Interior.Color = ColorTranslator.ToOle(Color.White);

                if (i == hotels.Length - 1)
                    aaaaah = i;
            }
            sheet.Cells[5 + aaaaah, 1] = "TOTAL";


        }
    }
}
