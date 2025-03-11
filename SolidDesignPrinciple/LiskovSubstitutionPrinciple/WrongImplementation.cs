using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.LiskovSubstitutionPrinciple
{
    public class WrongImplementation
    {
        public class PaymentProcessor
        {
            public virtual void AuthenticateUser()
            {
                Console.WriteLine("User authenticated");
            }
        }

        public class CreditCardPayment : PaymentProcessor
        {
            public override void AuthenticateUser()
            {
                Console.WriteLine("Credit Card user authenticated");
            }
        }

        // Violates LSP: Gift card payments don’t need authentication, but the method exists.
        public class GiftCardPayment : PaymentProcessor
        {
            public override void AuthenticateUser()
            {
                throw new NotImplementedException(); // Breaking LSP
            }
        }

    }
}
