﻿namespace StrategyPattern;
public interface IPaymentStrategy
{
    void ProcessPayment(float amount);
}