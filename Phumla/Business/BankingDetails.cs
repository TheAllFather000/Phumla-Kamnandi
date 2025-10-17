using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class BankingDetails
    {
        private string idNumber;
        private string cardNumber;
        private int cvv;
        private string expiryDate;
        private const int cardLength = 16; // The stanadard for Mastercard and the others.

        public string IDNumber
        { get { return idNumber; } set { idNumber = value; } }
        public string CardNumber
        { get { return cardNumber; } set { cardNumber = value; } }
        public int CVV
        { get { return cvv; } set { cvv = value; } }

        public string ExpiryDate
        { get { return expiryDate; } set { expiryDate = value; } }

        public BankingDetails()
        {
            cardNumber = "";
            cvv = 0;
            expiryDate = "08/2028";
        }

        public BankingDetails(string id, string card, int cvv, string ex)
        {
            this.idNumber = id;
            this.cardNumber = card;
            this.cvv = cvv;
            this.expiryDate = ex;
        }
        public BankingDetails(BankingDetails bd)
        {
            idNumber = bd.idNumber;
            cardNumber = bd.cardNumber;
            cvv = bd.cvv;
            expiryDate = bd.expiryDate;

        }

        public bool isCardNumberValid(string cardNumber)
        {
            return Convert.ToString(cardNumber).Length == cardLength && !string.IsNullOrEmpty(cardNumber) 
                && cardNumber.All(char.IsDigit);
        }

        public bool isCvvValid(string cvv)
        {
            return (Convert.ToString(cvv).Length == 3) || ( Convert.ToString(cvv).Length == 4) && !(string.IsNullOrEmpty(cvv))
                && cvv.All(char.IsDigit);
        }
        public bool isCardExpired(DateTime date)
        {
            return date < DateTime.Today;
        } 

    }
}
