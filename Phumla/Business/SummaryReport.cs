using Microsoft.Office.Interop.Excel;
using Phumla.Data;
using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Phumla.Business
{
    public class SummaryReport
    {
        private PaymentDB payments;
        private BookingDB bookings;
        static string[] headers = { "Hotel Name","Jan", "Feb", "Mar", "Apr" , "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec", "TOTAL"};
        static string[] hotels = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD"};
        static string[] columns = {"B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N" };

        string period1;
        string period2;
        Range range = null;
        public SummaryReport()
        { payments = new PaymentDB(); }

        public SummaryReport(string period) //before
        {
            payments = new PaymentDB();
            payments.SummaryReport(period);

            bookings = new BookingDB();
            bookings.occupancyForLess(period);
            period1 = period;
        }
        public SummaryReport (string period1, string period2) //between
        {
            payments = new PaymentDB();
            payments.SummaryBetween(period1, period2);

            bookings = new BookingDB();
            bookings.occupancyBetween(period1, period2);
            this.period1 = period1;
            this.period2 = period2;
        }

        public SummaryReport(string greater, Object o) //greater
        {
            payments = new PaymentDB();
            payments.SummaryGreater(greater);

            bookings = new BookingDB();
            bookings.occupancyGreater(greater);
            period1 = greater;
        }

        public SummaryReport(string greater, int o) //general
        {
            bookings = new BookingDB();
            bookings.occupancyForAll();
            period1 = greater;
        }
        public void GenerateSummaryReport()
        {
            Excel.Application application = new Excel.Application();
            application.Visible = true;

            Excel.Workbook workbook = application.Workbooks.Add(); //creating excel file
            Excel.Worksheet sheet = workbook.Worksheets.Add(); //creating sheet.
            Excel.Range phumlakTitle = sheet.get_Range("A1", "F1"); //getting the top section for the header.
            //making the headers and note
            phumlakTitle.Merge();
            if (period2 == null)
            {
                phumlakTitle.Value = "Phumla Kamnandi: Occupancy Report For (" + period1 + ")";

            }
            else
            {
                phumlakTitle.Value = "Phumla Kamnandi: Occupancy Report For (" + period1 + "- " + period2 + ")";
            }
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

            sheet.Cells[3, 1] = " Report is subject to change. All rights reserved.";
            noteRange = sheet.get_Range("A3", "E3");

            noteRange.Merge();
            noteRange.Font.Italic = true;
            noteRange.Font.Size = 10;
            noteRange.Font.Color = System.Drawing.Color.Black;

            sheet.Columns["A:D"].AutoFit();

            for(int i = 0; i < headers.Length; i++)
            {
                sheet.Cells[4, i+1] = headers[i];
            }
            
            Excel.Range headerRange = sheet.Range["A4", "N4"];
            headerRange.Font.Bold = true;
            headerRange.Font.Size = 10;
            
            headerRange.Interior.Color = ColorTranslator.ToOle(Color.DarkGreen);
            headerRange.Font.Color = System.Drawing.Color.White;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            int aaaaah = 0;
            for (int  i = 0; i < hotels.Length; i++)
            {
                sheet.Cells[5 + i, 1] = "Hotel "+hotels[i];
                Console.WriteLine(hotels[i]);
                range = sheet.Range["A"+(5+i), "N"+(5+i)];
                if (i % 2 == 1)
                    range.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
                else
                    range.Interior.Color = ColorTranslator.ToOle(Color.White);

                if (i == hotels.Length - 1)
                    aaaaah = i;
            }
            sheet.Cells[5 + aaaaah, 1] = "Hotel AD";
            sheet.Cells[5 + aaaaah + 1, 1] = "Total";
            int startinginsertion = 5;
            DataSet ds = payments.getDataSet();
            int j = 0;
            foreach (DataRow r in ds.Tables["Payment"].Rows)
            {
                sheet.Cells[startinginsertion+j, 2] = Convert.ToString(r["Jan"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 3] = Convert.ToString(r["Feb"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 4] = Convert.ToString(r["Mar"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 5] = Convert.ToString(r["Apr"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 6] = Convert.ToString(r["May"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 7] = Convert.ToString(r["Jun"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 8] = Convert.ToString(r["Jul"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 9] = Convert.ToString(r["Aug"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 10] = Convert.ToString(r["Sep"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 11] = Convert.ToString(r["Oct"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 12] = Convert.ToString(r["Nov"]).Replace(".", ",");
                sheet.Cells[startinginsertion+j, 13] = Convert.ToString(r["Dec"]).Replace(".", ",");
                startinginsertion++;
                Console.WriteLine(startinginsertion+j);
            }
            int m = 5;
            for (int z = 0; z < hotels.Length; z++)
            {
                range = sheet.Range["N"+(m)+":"+"N"+(m)];
                range.Formula = "=SUM(B"+(m)+":M"+(m)+")";
                m++;
            }
            m = 5;
            for (int z = 0; z <columns.Length;z++ )
            {
                range = sheet.Range[columns[z]+35+":"+columns[z]+35];
                range.Formula = "=SUM(" + columns[z] + 5 + ":" + columns[z]+34+")";
            }
            workbook.ReadOnlyRecommended = true;



        }
        public void GenerateOccupancyReport()
        {
            Excel.Application application = new Excel.Application();
            application.Visible = true;

            Excel.Workbook workbook = application.Workbooks.Add(); //creating excel file
            Excel.Worksheet sheet = workbook.Worksheets.Add(); //creating sheet.
            Excel.Range phumlakTitle = sheet.get_Range("A1", "F1"); //getting the top section for the header.
            //making the headers and note
            phumlakTitle.Merge();
            if (period2 == null)
            {
                phumlakTitle.Value = "Phumla Kamnandi: Occupancy Report For ("+period1+")" ;

            }
            else
            {
                phumlakTitle.Value = "Phumla Kamnandi: Occupancy Report For (" + period1 + "- "+period2+")";
            }
            phumlakTitle.Font.Bold = true;
            phumlakTitle.Font.Size = 14;
            phumlakTitle.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            phumlakTitle.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            phumlakTitle.Font.Color = System.Drawing.Color.Black;

            application.ActiveWindow.DisplayGridlines = true;
            //note cell
            Excel.Range noteRange = sheet.get_Range("A2", "E2");

            sheet.Cells[2, 1] = " Report is subject to change. All rights reserved.";
            noteRange.Merge();
            noteRange.Font.Italic = true;
            noteRange.Font.Size = 10;
            noteRange.Font.Color = System.Drawing.Color.Black;

            sheet.Columns["A:D"].AutoFit();

            for (int i = 0; i < headers.Length; i++)
            {
                sheet.Cells[4, i + 1] = headers[i];
            }

            Excel.Range headerRange = sheet.Range["A4", "N4"];
            headerRange.Font.Bold = true;
            headerRange.Font.Size = 10;

            headerRange.Interior.Color = ColorTranslator.ToOle(Color.DarkGreen);
            headerRange.Font.Color = System.Drawing.Color.White;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            int aaaaah = 0;
            for (int i = 0; i < hotels.Length; i++)
            {
                sheet.Cells[5 + i, 1] = "Hotel " + hotels[i];
                Console.WriteLine(hotels[i]);
                range = sheet.Range["A" + (5 + i), "N" + (5 + i)];
                if (i % 2 == 1)
                    range.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
                else
                    range.Interior.Color = ColorTranslator.ToOle(Color.White);

                if (i == hotels.Length - 1)
                    aaaaah = i;
            }
            sheet.Cells[5 + aaaaah, 1] = "Hotel AD";
            sheet.Cells[5 + aaaaah + 1, 1] = "Total";
            int startinginsertion = 5;
            DataSet ds = bookings.getDataSet();
            int j = 0;
            foreach (DataRow r in ds.Tables["Booking"].Rows)
            {
                sheet.Cells[startinginsertion + j, 2] = Convert.ToString(r["Jan"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 3] = Convert.ToString(r["Feb"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 4] = Convert.ToString(r["Mar"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 5] = Convert.ToString(r["Apr"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 6] = Convert.ToString(r["May"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 7] = Convert.ToString(r["Jun"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 8] = Convert.ToString(r["Jul"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 9] = Convert.ToString(r["Aug"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 10] = Convert.ToString(r["Sep"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 11] = Convert.ToString(r["Oct"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 12] = Convert.ToString(r["Nov"]).Replace(".", ",");
                sheet.Cells[startinginsertion + j, 13] = Convert.ToString(r["Dec"]).Replace(".", ",");
                startinginsertion++;
                Console.WriteLine(startinginsertion + j);
            }
            int m = 5;
            for (int z = 0; z < hotels.Length; z++)
            {
                range = sheet.Range["N" + (m) + ":" + "N" + (m)];
                range.Formula = "=SUM(B" + (m) + ":M" + (m) + ")";
                m++;
            }
            m = 5;
            for (int z = 0; z < columns.Length; z++)
            {
                range = sheet.Range[columns[z] + 35 + ":" + columns[z] + 35];
                range.Formula = "=SUM(" + columns[z] + 5 + ":" + columns[z] + 34 + ")";
            }
            workbook.ReadOnlyRecommended = true;
        }
    }
}
