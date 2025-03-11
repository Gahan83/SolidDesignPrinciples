using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.OpenClosedPrinciple
{
    // New payment method added without modifying existing code
    public class BitcoinPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Processing Bitcoin Payment");
        }
    }
}
