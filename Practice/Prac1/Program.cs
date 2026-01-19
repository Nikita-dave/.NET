using System;
using System.Reflection.Metadata;

class Prac1
{
    public static void Main(string[] arg)
    {
        Billing billing = new Billing();
        Billing billing1 = new Billing(10,20);

        Console.WriteLine($"Default Constructor Values: Number1 = {billing.Number1}, Number2 = {billing.Number2}");
        Console.WriteLine($"Parameterized Constructor Values: Number1 = {billing1.Number1}, Number2 = {billing1.Number2}");
    }
}
