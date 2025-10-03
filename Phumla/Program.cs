﻿using Phumla.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla.Business;
using Phumla.Data;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Guest g = new Guest("Ibrahim Sow", 18, 00050505050, "ibrahimsow367@gmail.com","+27 78 377 6253", 4.5);
            Booking b = new Booking();
            b.DepositStatus = true;
            b.Bill = 0;
            AccessDB accessDB = new AccessDB();
            //new Email().sendCheckIn(g, b, "mewingbitch", "Booking Confirmation: " + g.Name, "PK HOTEL1", "GAAAAAA", "AAAAAAAAA" , "55A, 55B, 56C");
            Application.Run(new AddGuest());
        }
    }
}
