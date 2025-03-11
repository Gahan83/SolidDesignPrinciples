namespace SolidDesignPrinciple.DependecyInversionPrinciple
{
    public class WrongSolution
    {
        public class PaymentProcessor
        {
            private CreditCardPayment _creditCardPayment = new CreditCardPayment();
            private PayPalPayment _paypalPayment = new PayPalPayment();

            public void ProcessCreditCard()
            {
                _creditCardPayment.Pay();
            }

            public void ProcessPayPal()
            {
                _paypalPayment.Pay();
            }
        }

    }
}
