using Phumla.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class PaymentController
    {
        PaymentDB payment;

        public PaymentController()
        {
            payment = new PaymentDB();
            
        }
    }
}
