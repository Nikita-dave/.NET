using System;
// namespace PartialDemo
namespace CalculatorApp
{
    //declaration of delegate
    public delegate int CalculatorDelegate(int n1,int n2);
    class Program
{
    public static void Main(string[] arg)
    {
        // IPayment payment;
        // payment = new CreditCardPayment();
        // payment.Refund(1000.0);
        // payment.Pay(1000.0);
        // UPIPayment upi = new UPIPayment();
        // upi.Refund(2000.0);
        // upi.Pay(2000.0);

        //include namespace for partial to run
        // PartialEmployee part = new PartialEmployee();
        // part.FirstName = "Rajesh";
        // part.DisplayEmployeeDetails();
        // part.DisplayFullName();
        // part.PartialMethod();


        Calculator calculator = new Calculator();
        //Initializing the delegate
        CalculatorDelegate calcAdd = new CalculatorDelegate(calculator.Add);
        CalculatorDelegate calcSubtract = new CalculatorDelegate(calculator.Subtract);
        CalculatorDelegate calcMultiply = new CalculatorDelegate(calculator.Multiply);
        CalculatorDelegate calcDivide = new CalculatorDelegate(calculator.Divide);
        CalculatorDelegate calcMulticast;

        //Calculate the delegate single cast delegate
        int sum = calcAdd(30,20);
        System.Console.WriteLine("Sum of the two number is {0}",sum);

        int sub = calcSubtract(30,20);
        System.Console.WriteLine("Difference of the two number is {0}",sub);

        int mul = calcMultiply(30,20);
        System.Console.WriteLine("Multiplication of the two number is {0}",mul);

        int div = calcDivide(30,20);
        System.Console.WriteLine("Division of the two number is {0}",div);

        calcMulticast=calcAdd;
        calcMulticast+=calcSubtract;
        calcMulticast-=calcMultiply;
        calcMulticast+=calcDivide;

        System.Console.WriteLine("Called Multicast Delegate {0}", calcMulticast(30,3));
    }
}
}