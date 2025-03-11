namespace SolidDesignPrinciple.LiskovSubstitutionPrinciple
{
    // No need for authentication
    public class GiftCardPayment : PaymentProcessor
    {
        public override void Pay()
        {
            Console.WriteLine("Processing Gift Card Payment");
        }
    }
}
