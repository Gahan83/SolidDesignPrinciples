namespace SolidDesignPrinciple.InterfaceSegregationPrinciple
{

    public class GiftCardPayment : IPayment
    {
        public void Pay() { Console.WriteLine("Processing Gift Card Payment"); }
    }

}
