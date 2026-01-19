using System;

class Banking
{
    public static void Main(string[] args)
    {
        Calc calc = new Calc();

        int number1=10;
        int number2=20;
        int sum = calc.Add(number1,number2);
        Console.WriteLine($"Sum of the number {number1} and {number2} is {sum}");

        int subtract = calc.Subtract();
        Console.WriteLine($"Subtraction of the number is {subtract}");

        calc.Multiply(15, 2);

        calc.Divide();

    }
}
