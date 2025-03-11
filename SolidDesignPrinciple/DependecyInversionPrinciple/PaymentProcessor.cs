namespace SolidDesignPrinciple.DependecyInversionPrinciple
{
    public class PaymentProcessor
    {
        private readonly IPayment _payment;

        public PaymentProcessor(IPayment payment)
        {
            _payment = payment;
        }

        public void ProcessPayment()
        {
            _payment.Pay();
        }
    }
}
