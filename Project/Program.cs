using System;
using System.Diagnostics;

class Program
{
   public static void Main(string[] arg)
    {
        // //CALLING NEW CALCULATOR AS DEFAULT CONSTRUCTOR
        // Calculator calculator = new Calculator();

        // int number1=10;
        // int number2=20;
        // int sum = calculator.Add(number1,number2);
        // Console.WriteLine($"Sum of the number {number1} and {number2} is {sum}");

        // int subtract = calculator.Subtract();
        // Console.WriteLine($"Subtraction of the number is {subtract}");

        // calculator.Multiply(15, 2);

        // calculator.Divide();

        // //Calling new Calculator as Parameterised Constructor
        // Calculator calculator1 = new Calculator( 15,2);

        // Calculator calculator = new Calculator();
        // int n1 = 30;
        // int n2 =  20;
        // Console.WriteLine($"Before Swaping {n1} and {n2}");
        // calculator.Swap(n1,n2);
        // Console.WriteLine($"After Swaping {n1} and {n2}");
        // Console.WriteLine();

        // //call by reference
        // int n3 = 30;
        // int n4 =  20;
        // Console.WriteLine($"Before Swaping {n3} and {n4}");
        // calculator.Swapref(ref n3,ref n4);
        // Console.WriteLine($"After Swaping {n3} and {n4}");

        // Calculator calculator2 = new Calculator();
        // int num1=30;
        // int num2=50;
        // int res= 0;
        // int num3=0;
        // int num4=0;

        // calculator2.Addition(num1,num2,out res,out num3,out num4);
        // Console.WriteLine($"First Number is {num3} Second number is {num4} Addition is {res}");

        StaticCons demo = new StaticCons();
        demo.var = 30;
        demo.Count();
        demo.Count();
        demo.Count();
        Console.WriteLine($"Instance variable after incrementing {StaticCons.Display()}");
        StaticCons demo1 = new StaticCons();
        demo1.Count();
        Console.WriteLine($"Instance variable after incrementing {StaticCons.Display()}");
        //demo.var1=40;//Error Cannot access static variable or method through instance
        StaticCons.var1=50;
        demo1.Count();
        demo1.Count();
        demo1.Count();
        demo1.Count();
        demo1.Count();
        Console.WriteLine($"Static variable after incrementing {StaticCons.Display()}");
        StaticCons demo2 = new StaticCons();;
        demo2.Count();
        demo2.Count();
        demo2.Count();

        Console.WriteLine($"Instance variable after incrementing {StaticCons.Display()}");
    } 
}

