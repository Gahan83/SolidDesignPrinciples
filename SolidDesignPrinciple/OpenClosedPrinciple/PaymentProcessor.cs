namespace SolidDesignPrinciple.OpenClosedPrinciple
{
    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentType)
        {
            if (paymentType == "CreditCard")
            {
                Console.WriteLine("Processing Credit Card Payment");
            }
            else if (paymentType == "PayPal")
            {
                Console.WriteLine("Processing PayPal Payment");
            }
            else if (paymentType == "Bitcoin") // Adding new payment breaks OCP
            {
                Console.WriteLine("Processing Bitcoin Payment");
            }
        }
    }

}
