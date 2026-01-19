using System;

class Calc
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public int Result { get; set; }

    public Calc()//default constructor
    {
        Number1=0;
        Number2=0;
        Result=0;
    }

     public int Add(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
        Result = number1+number2;
        return Result;
    }

    public int Subtract()
    {
        Number1 = 30;
        Number2 = 20;
        Result = Number1-Number2;

        return Result;
    }

    public void Multiply(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
        Result = Number1*Number2;
        Console.WriteLine($"Multiplication of the two number {Number1} and {Number2} is {Result}");
    }

    public void Divide()
    {
        Result = Number1/Number2;
        Console.WriteLine($"Division of the two Numbers {Number1} and {Number2} is {Result}");
    }
}