namespace SolidDesignPrinciple.LiskovSubstitutionPrinciple
{
    public class CreditCardPayment : AuthenticatedPayment
    {
        public override void AuthenticateUser()
        {
            Console.WriteLine("Credit Card user authenticated");
        }

        public override void Pay()
        {
            Console.WriteLine("Processing Credit Card Payment");
        }
    }


}
