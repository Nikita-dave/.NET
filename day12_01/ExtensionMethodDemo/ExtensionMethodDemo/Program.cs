using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;
namespace ExtensionMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(30,20);
            int subtract = calculator.Subtract(30,20);
            int division = calculator.Division(30, 2);
            int product = calculator.Multiply(30, 20);
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Subtract is {subtract}");
            Console.WriteLine($"Division is {division}");
            Console.WriteLine($"Product is {product}");
        }
    }
}
