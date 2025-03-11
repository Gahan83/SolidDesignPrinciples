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

//////////////////////////////////////
//using SolidDesignPrinciple.OpenClosedPrinciple;

/////Open Closed Principle
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