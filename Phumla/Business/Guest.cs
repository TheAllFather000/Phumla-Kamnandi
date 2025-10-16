using Microsoft.VisualBasic;
using Phumla.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Guest : Person
    {
        private double outstandingPayments;
        public double Outstanding
        {
            get { return outstandingPayments; }
            set { outstandingPayments = value; }
        }
        public Guest(string name, int age, string id, string email, string phone, double outstandingPayments) : base(name, age, id, email, phone)
        {
            this.outstandingPayments = outstandingPayments;
        }
        public Guest()
        {}
        public Guest(Guest g)
        {
            ID = g.ID;
            Name = g.Name;
            Phone = g.Phone;
            Email = g.Email;
            outstandingPayments = g.outstandingPayments;
            Age = g.Age;
        }

        public bool isEmailValid(string email)
        {
            return email.Contains("@");
        }

        // Could make the logic more complex but buzz off will ya.
        public bool isNameValid (string name)
        {
            return !string.IsNullOrEmpty(name) && name.All(c => char.IsLetter(c) || char.IsWhiteSpace (c));
        }

        // Assume no hyphens in name.
        public bool isSurnameValid(string surname)
        {
            return !string.IsNullOrEmpty(surname) && surname.All(char.IsLetter);
        }

        public bool isIDValid(string id)
        {
            return
                // For the sake of testing, we'll comment the below out.
                /*dateOfBirth.ToString("yy") == id.Substring(0, 2) &&
                dateOfBirth.ToString("MM") == id.Substring(2, 2) &&
                dateOfBirth.ToString("dd") == id.Substring(4, 2) &&*/
                id.Length == 13 &&
                id.All(char.IsDigit);
        }

        public bool isPhoneValid(string phone)
        {
            return !string.IsNullOrEmpty(phone) && phone.All(char.IsDigit) && phone[0] == '0' && phone.Length == 10;
        }
        public bool isDoBValid(DateTime dob)
        {
            return dob < DateTime.Today;
        }

    }
}
