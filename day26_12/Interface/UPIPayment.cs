using System;

class UPIPayment: IPayment
{
    public void Pay(double amount)
    {
        System.Console.WriteLine($"Paid {amount} using UPI.");
    }

    public void Refund(double amount)
    {
        System.Console.WriteLine($"Refunded {amount} to UPI.");
    }
}

