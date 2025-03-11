namespace SolidDesignPrinciple.DependecyInversionPrinciple
{
    class PayPalPayment : IPayment
    {
        public void Pay() { Console.WriteLine("Processing Pay Pal Payment"); }
    }
}
