using Phumla.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla.Business;
using Phumla.Data;
using System.Data.Common;

namespace Phumla
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Guest g = new Guest("Ibrahim Sow", 18, 00050505050, "ibrahimsow367@gmail.com","+27 78 377 6253", 4.5);
            Booking b = new Booking();
            b.DepositStatus = true;
            b.Bill = 0;
            AccessDB employeeDB = new AccessDB();
            Employee.AccessLevel employee = employeeDB.checkLoginDetails(110113, "eishyahneh");
            //new Email().sendCheckIn(g, b, "mewingbitch", "Booking Confirmation: " + g.Name, "PK HOTEL1", "GAAAAAA", "AAAAAAAAA" , "55A, 55B, 56C");
            */
            DB db = new DB();
            /* string createcommand = @"CREATE TABLE Booking
                                      (id bigint IDENTITY(1,1) not null,
                                      guestid bigint not null,
                                       hotelid bigint not null,
                                       roomid  text,
                                       bookingdate date not null,
                                       bookingtime time not null,
                                       bookingend DATE not null,
                                       depositstatus int not null,
                                       checkin int not null,
                                       bill double precision,
                                       CONSTRAINT Booking_Details PRIMARY KEY (id, guestid, hotelid)
                                     );";
             db.createTable(createcommand);*/
            //guest.AddGuest(new Guest("Testing", 12, "564561", "phumla@k.gmail.com", "+test", 100));
            //Populator populator = new Populator();
            // populator.populateHotels();
            //SummaryReport summaryReport = new SummaryReport();
            //summaryReport.GenerateSummaryReport();
            //HotelPopulator pop = new HotelPopulator();
            //pop.populateHotels();
            // Don't run populate, hotels are already populated.
            Application.Run(new Presentation.HomePage());
        }
    }
}
