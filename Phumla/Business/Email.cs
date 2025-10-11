using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Phumla.Business
{
    //class meant for sending emails.
    public class Email
    {
        private MailMessage mail;
        private SmtpClient smtp;
        private string sender;
        private string subject;
        private string reciever;
        public const string email = "phumlak699@gmail.com";
        public const string password = "mpji irmi vxwz ybar";
        public string Subject { get { return subject; } set { subject = value; } }
        public string Sender { get { return sender; } set { sender = value; } }

        public static string bookingMade = "Dear {0} {1},\n\n" +
    "We are pleased to confirm your booking with Phumla Kamnandi.\n\n" +
    "Booking Details:\n" +
    "----------------------------------\n" +
    "Guest Name: {0} {1}\n" +
    "ID Number: {2}\n" +
    "Hotel: {3}\n" +
    "Booking Date & Time: {4}\n" +
    "Number of Rooms: {5}\n" +
    "Current Bill: {6}\n" +
    "----------------------------------\n\n" +
    "Thank you for choosing Phumla Kamnandi. We look forward to hosting you!\n\n" +
    "Warm regards,\n" +
    "Phumla Kamnandi Reservations Team";
        public const string checkInTemplate =
        "Dear {0} {1},\n\n" +
        "Welcome to {2}! Your check-in has been successfully completed.\n\n" +
        "Stay Details:\n" +
        "----------------------------------\n" +
        "Hotel: {2}\n" +
        "Stay Period: {3} to {4}\n" +
        "Check-In Time: {5}\n" +
        "Check-Out Time: {6}\n" +
        "Room(s) Assigned: {7}\n\n" +
        "Deposit Information:\n" +
        "----------------------------------\n" +
        "{8}\n" +
        "----------------------------------\n\n" +
        "We hope you enjoy your stay with Phumla Kamnandi!\n\n" +
        "Warm regards,\n" +
        "Phumla Kamnandi Guest Services Team";


        public static string checkIn = "Dear {0} {1},\n\n" +
    "Welcome to {2}! Your check-in has been successfully completed.\n\n" +
    "Stay Details:\n" +
    "----------------------------------\n" +
    "Hotel: {2}\n" +
    "Stay Period: {3} to {4}\n" +
    "Check-In Time: {5}\n" +
    "Check-Out Time: {6}\n" +
    "Room(s) Assigned: {7}\n\n" +
    "Deposit Information:\n" +
    "----------------------------------\n" +
    "{8}\n" +
    "----------------------------------\n\n" +
    "We hope you enjoy your stay with Phumla Kamnandi!\n\n" +
    "Warm regards,\n" +
    "Phumla Kamnandi Guest Services Team";


        public const string changedBooking=
        "Dear {0} {1},\n\n" +
        "This email is to notify you about a change made to your booking for the date of {2}\n\n" +
        "New Stay Details:\n" +
        "----------------------------------\n" +
        "Hotel: {3}\n" +
        "Stay Period: {4} to {5}\n" +
        "Check-In Time: {6}\n" +
        "Room(s) Assigned: {7}\n\n" +
        "----------------------------------\n" +
        "Please feel free to contact us in the event that another change is needed.\n\n" +
        "Warm regards,\n" +
        "Phumla Kamnandi Guest Services Team";

        public const string deleted =
        "Dear {0} {1},\n\n" +
        "This email is to notify you that your booking for the date of {2} has been deleted.\n\n" +

        "Please feel free to contact us if this is believed to be an error.\n\n" +
        "Warm regards,\n" +
        "Phumla Kamnandi Guest Services Team";

        public Email()
        { }
        public Email(Guest g, Booking b, int numrooms,string hotel)
        {
            sender = email;
            reciever = g.Email;
            mail = new MailMessage();
            smtp = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(sender);
            mail.To.Add(g.Email);
            mail.Subject = "Booking Confirmation: "+ g.Name.Split()[0]+ " "+ g.Name.Split()[1];
            string bod = string.Format
                (bookingMade,
                g.Name.Split()[0], g.Name.Split()[1],
                g.ID,
                hotel, b.BookingTime,
                b.BookingDate,
                numrooms,
                b.Bill);
            Console.WriteLine(bod);
            mail.Body = bod;
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(sender, password);
            smtp.EnableSsl = true;
            
        }

        public void Delete(Guest g, Booking b)
        {
            string message = string.Format(deleted, g.Name.Split()[0], g.Name.Split()[1], b.BookingDate);
            mail = new MailMessage();
            smtp = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(email);
            mail.To.Add(g.Email);
            mail.Subject = "Deleted Booking: " + g.Name.Split()[0] + " " + g.Name.Split()[1];
            mail.Body = message;
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(email, password);
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        
        public void addRecipient(string recipient)
        {
            mail.To.Add(recipient);
        }
        public void changeBody(string bo)
        {
            mail.Body = bo;
        }
        public void changeFrom(string from)
        {
            mail.From = new MailAddress(from);
        }
        public void sendBookingMail()
        {
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
        }
        public void sendChangeEmail(Guest g, Booking b, string hotelname)
        {
            string message = string.Format(changedBooking, g.Name.Split()[0], g.Name.Split()[1], b.BookingDate, hotelname, b.BookingDate, b.BookingEnd, b.BookingTime, b.RoomNumber);
            mail = new MailMessage();
            smtp = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(email);
            mail.To.Add(g.Email);
            mail.Subject = "Change in Booking: " + g.Name.Split()[0] + " " + g.Name.Split()[1];
            mail.Body = message;
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(email, password);
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void sendCheckIn(Guest g, Booking b, string hotel, string startdate, string enddate, string checkintime, string checkouttime,
            string rooms)
        {
            string depositMessage = b.DepositStatus ?
                                    "Your deposit has been paid in full."
                                  : $"Deposit outstanding: ZAR {b.Bill}";
            string bod = string.Format
                (checkIn,
                g.Name.Split()[0], g.Name.Split()[1],
                hotel,
                startdate,
                enddate,
                checkintime,
                checkouttime,
                rooms,
                depositMessage
                );
            Console.WriteLine(bod);
            mail = new MailMessage();
            smtp = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(email);
            mail.To.Add(g.Email);
            mail.Subject = "Check In: " + g.Name.Split()[0] + " " + g.Name.Split()[1];
            mail.Body = bod;
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(email, password);
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}