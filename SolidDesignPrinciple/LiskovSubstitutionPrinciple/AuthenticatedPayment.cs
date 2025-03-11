namespace SolidDesignPrinciple.LiskovSubstitutionPrinciple
{
    public abstract class AuthenticatedPayment : PaymentProcessor
    {
        public abstract void AuthenticateUser();
    }
}
