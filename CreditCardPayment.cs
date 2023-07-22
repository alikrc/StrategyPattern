namespace StrategyPattern;

public class CreditCardPayment : IPaymentStrategy
{
    private string cardNumber;
    private string cardHolderName;
    private string expirationDate;
    private string cvv;

    public CreditCardPayment(string cardNumber, string cardHolderName, string expirationDate, string cvv)
    {
        this.cardNumber = cardNumber;
        this.cardHolderName = cardHolderName;
        this.expirationDate = expirationDate;
        this.cvv = cvv;
    }

    public void ProcessPayment(float amount)
    {
        Console.WriteLine($"Paid {amount:C2} with Credit Card.");
    }
}
