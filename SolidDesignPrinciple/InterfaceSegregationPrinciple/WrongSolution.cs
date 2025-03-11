using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.InterfaceSegregationPrinciple
{
    public class WrongSolution
    {
        public interface IPayment
        {
            void Pay();
            void AuthenticateUser(); // Not all payments need authentication
        }

        public class CreditCardPayment : IPayment
        {
            public void Pay() { Console.WriteLine("Processing Credit Card Payment"); }
            public void AuthenticateUser() { Console.WriteLine("Authenticating user"); }
        }

        public class GiftCardPayment : IPayment
        {
            public void Pay() { Console.WriteLine("Processing Gift Card Payment"); }

            public void AuthenticateUser()
            {
                throw new NotImplementedException(); // Breaking ISP
            }
        }

    }
}
