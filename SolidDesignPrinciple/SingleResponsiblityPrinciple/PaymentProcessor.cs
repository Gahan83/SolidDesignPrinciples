namespace SolidDesignPrinciple.SingleResponsiblityPrinciple
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

            // Also handling logging (wrong)
            Console.WriteLine("Logging payment details to the database...");
        }

    }
}
