using System;
using System.ComponentModel.Design;

class Utility
{
    public static void Main(string[] args)
    {
        Service service = new Service();
        service.Number1 = 50;
        service.Number2 = 30;
        service.Result = service.Number1 + service.Number2;
        Console.WriteLine($"The Sum of {service.Number1} and {service.Number2} is {service.Result}");
    }
}
