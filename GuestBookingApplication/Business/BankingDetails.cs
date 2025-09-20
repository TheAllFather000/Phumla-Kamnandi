using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingApplication.Business
{
    public class BankingDetails
    {
        
        private long idNumber;
        private long cardNumber;
        private int cvv;
        private string expiryDate;
        

        public long IDNumber
        { get { return idNumber; } set { idNumber = value; } }
        public long CardNumber
            { get { return cardNumber; } set { cardNumber = value; } }
        public int CVV
        {  get { return cvv; } set { cvv = value; } }

        public string ExpiryDate
        { get { return expiryDate; } set { expiryDate = value; } }

        public BankingDetails()
        {
            cardNumber = 0;
            cvv = 0;
            expiryDate = "08/2028";
        }

        public BankingDetails(long id, long card, int cvv, string ex)
        {
            this.idNumber = id;
            this.cardNumber=card;
            this.cvv = cvv;
            this.expiryDate=ex;
        }


    }
}
