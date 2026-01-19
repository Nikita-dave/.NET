using System;
class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        System.Console.WriteLine($"Paid {amount} using Credit Card.");
    }

    public void Refund(double amount)
    {
        System.Console.WriteLine($"Refunded {amount} to Credit Card.");
    }
}

// internal interface IPayment
// {
//     void Pay(double amount);
//     void Refund(double amount);
// }