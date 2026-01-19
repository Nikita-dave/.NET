using System;
class Program //subscriber Class
{
    private static int result;
    public static void Main(string[] args)
    {
        // AddTwoNumbers a = new AddTwoNumbers();
        // a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
        // a.Add();
        // // delegates calls this method when event raised
        // static void EventMessage()
        // {
        //     System.Console.WriteLine("*******Event Executed : This is odd Number********");
        // }

        // Func<int, int, int> Addition = AddNumbers;
        // int result = Addition(10, 20);
        // System.Console.WriteLine($"Addition = {result}");

        Action<int, int> Addition = AddNumbers;
        Addition(10,20);
        System.Console.WriteLine($"Addition = {result}");

        Predicate<string> CheckIfApple = IsApple;
        bool isAppleDevice = IsApple("IPhone X");
        if(isAppleDevice && result > 0)
        System.Console.WriteLine("It's an IPhone");

    }

    private static void AddNumbers(int num1, int num2)
    {
        result = num1 + num2;
    }

    private static bool IsApple(string deviceName)
    {
        return deviceName.Contains("Apple") || deviceName.Contains("IPhone");
    }
}