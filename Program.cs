using StrategyPattern;

var creditCardPayment = new CreditCardPayment("2321321", "Foo Bar", "23-12-2023", "231");

var context = new PaymentContext(creditCardPayment);
context.MakePayment(10.99f);

var payPalStrategy = new PayPalPayment("foo@bar.com", "pass");
context.SetPaymentStrategy(payPalStrategy);
context.MakePayment(133.99f);