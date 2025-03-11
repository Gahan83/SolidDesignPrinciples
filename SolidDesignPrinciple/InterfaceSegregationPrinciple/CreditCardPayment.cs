namespace SolidDesignPrinciple.InterfaceSegregationPrinciple
{
    public class CreditCardPayment : IPayment, IAuthenticatedPayment
    {
        public void Pay() { Console.WriteLine("Processing Credit Card Payment"); }
        public void AuthenticateUser() { Console.WriteLine("Authenticating user"); }

    }
}
