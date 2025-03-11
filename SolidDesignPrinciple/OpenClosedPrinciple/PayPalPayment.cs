using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.OpenClosedPrinciple
{
    public class PayPalPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Processing PayPal Payment");
        }
    }
}
