using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.SingleResponsiblityPrinciple
{
    public class CreditCardPayment: IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Processing Credit Card Payment");
        }
    }
}
