﻿namespace StrategyPattern;

public class PaymentContext
{

    private IPaymentStrategy paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy sortStrategy)
    {
        paymentStrategy = sortStrategy;
    }

    public void MakePayment(float amount)
    {
        paymentStrategy.ProcessPayment(amount);
    }
}
