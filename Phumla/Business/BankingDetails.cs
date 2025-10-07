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
        private long cardNumber;
        private int cvv;
        private string expiryDate;
        

        public string IDNumber
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

        public BankingDetails(string id, long card, int cvv, string ex)
        {
            this.idNumber = id;
            this.cardNumber=card;
            this.cvv = cvv;
            this.expiryDate=ex;
        }
        public BankingDetails(BankingDetails bd)
        {
            idNumber = bd.idNumber;
            cardNumber = bd.cardNumber;
            cvv = bd.cvv;
            expiryDate = bd.expiryDate;

        }


    }
}
