using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Phumla.Business
{
    //class meant for sending emails.
    public class Email
    {
        private MailMessage mail;
        private SmtpClient smtp;
        private string sender;
        private string subject;
        private string body;
        private string reciever;
        public string Subject { get { return subject; } set { subject = value; } }
        public string Sender { get { return sender; } set { sender = value; } }
        public string Body { get { return body; } set { body = value; } }

        public Email()
        { }
        public Email(string s ,string rec, string sub, string bod)
        {
            sender = s;
            subject = sub;
            body = bod;
            reciever = rec;
            mail = new MailMessage();
            smtp = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(sender);
            mail.To.Add(rec);
            mail.Subject = sub;
            mail.Body = bod;
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(s, "INSERT PASSWORD HERE");
            smtp.EnableSsl = true;
            
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
            mail.From = new MailAddress (from);
        }
        public void sendMail()
        {
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
        }
    }
}
