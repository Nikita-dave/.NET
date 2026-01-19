using System;

class TempConv
{
    public static void Convertor()
    {    
        try
        {
            double temp = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToUpper();
            double result;
            if(type == "C")
            {
                result = (temp * 9 / 5) + 32;
                System.Console.WriteLine("Temperature in Fahrenheit: {0:F2}", result);
            }
            else if(type == "F")
            {
                result = (temp - 32) * 5 / 9;
                System.Console.WriteLine("Temperature in Celsius: {0:F2}",result);
            }
            else
            {
                System.Console.WriteLine("Invalid Conversion Type. Please enter 'F' or 'C'.");
            }
        }
        catch (FormatException e)
        {
            System.Console.WriteLine("Error: Invalid Input Provided");
            System.Console.WriteLine($"Exception: {e.Message}");
        }
    }
}