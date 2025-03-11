//SRP:
// Create payment methods
//IPayment creditCardPayment = new CreditCardPayment();
//IPayment payPalPayment = new PayPalPayment();

//// Create processor and logger
//NewPaymentProcessor processor = new NewPaymentProcessor();
//PaymentLogger logger = new PaymentLogger();

//// Process Credit Card Payment
//processor.ProcessPayment(creditCardPayment);
//logger.LogPayment();

//Console.WriteLine();

//// Process PayPal Payment
//processor.ProcessPayment(payPalPayment);
//logger.LogPayment();

//Console.WriteLine("\nPayment processing completed.");

///////////////////////////////////////////////////////////////////

/////Open Closed Principle
//using SolidDesignPrinciple.OpenClosedPrinciple;
//IPayment creditCardPayment = new CreditCardPayment();
//IPayment payPalPayment = new PayPalPayment();
//IPayment bitcoinPayment = new BitcoinPayment();

//// Create processor and logger
//NewPaymentProcessor processor = new NewPaymentProcessor();

//// Process Credit Card Payment
//processor.ProcessPayment(creditCardPayment);

//Console.WriteLine();

//// Process PayPal Payment
//processor.ProcessPayment(payPalPayment);

//Console.WriteLine();

//// Process PayPal Payment
//processor.ProcessPayment(bitcoinPayment);

////////////////////////////////////////////////////////////////

/////Liskov Substitution Principle:
//using SolidDesignPrinciple.LiskovSubstitutionPrinciple;
// Process Credit Card Payment (Requires Authentication)
//AuthenticatedPayment creditCardPayment = new CreditCardPayment();
//creditCardPayment.AuthenticateUser();
//creditCardPayment.Pay();

//Console.WriteLine();

//// Process Gift Card Payment (No Authentication Required)
//PaymentProcessor giftCardPayment = new GiftCardPayment();
//giftCardPayment.Pay();

//Console.WriteLine("\nPayment processing completed.");

////////////////////////////////////////////////////////////////////////

//Interface Segregation Principle
//using SolidDesignPrinciple.InterfaceSegregationPrinciple;

//CreditCardPayment creditCardPayment = new CreditCardPayment();
//creditCardPayment.AuthenticateUser();
//creditCardPayment.Pay();

//Console.WriteLine();

//// Process Gift Card Payment (No Authentication Required)
//GiftCardPayment giftCardPayment = new GiftCardPayment();
//giftCardPayment.Pay();

/////////////////////////////////////////////////////////////////

//Dependency Inversion Principle:
using SolidDesignPrinciple.DependecyInversionPrinciple;

// Now we can inject any payment method at runtime.
IPayment payment = new CreditCardPayment();
PaymentProcessor processor = new PaymentProcessor(payment);
processor.ProcessPayment();