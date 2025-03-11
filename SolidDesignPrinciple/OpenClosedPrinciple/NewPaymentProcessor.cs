namespace SolidDesignPrinciple.OpenClosedPrinciple
{
    public class NewPaymentProcessor
    {
        public void ProcessPayment(IPayment payment)
        {
            payment.Pay();
        }

    }
}
