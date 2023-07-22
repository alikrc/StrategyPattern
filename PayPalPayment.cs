namespace StrategyPattern;

public class PayPalPayment : IPaymentStrategy
{
    private string email;
    private string password;

    public PayPalPayment(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    public void ProcessPayment(float amount)
    {
        Console.WriteLine($"Paid {amount:C2} with PayPal.");
    }
}