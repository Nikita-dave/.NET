class Calculator
{
    int a, b;
    int result;
    public void Add()
    {
        Console.WriteLine("Enter First Number");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        b = Convert.ToInt32(Console.ReadLine());
        result = a+b;
        Console.WriteLine($"Sum of the two Number is {result}");
    }
    public void Subtract()
    {
        Console.WriteLine("Enter First Number");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        b = Convert.ToInt32(Console.ReadLine());
        result = a-b;
        Console.WriteLine($"Subtraction of the two Number is {result}");
    }
    public void Multiply()
    {
        Console.WriteLine("Enter First Number");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        b = Convert.ToInt32(Console.ReadLine());
        result = a*b;
        Console.WriteLine($"Multiplication of the two Number is {result}");
    }
    public void Division()
    {
        Console.WriteLine("Enter First Number");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        b = Convert.ToInt32(Console.ReadLine());
        result = a/b;
        Console.WriteLine($"Division of the two Number is {result}");
    }

    public void Remainder()
    {
        Console.WriteLine("Enter First Number");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        b = Convert.ToInt32(Console.ReadLine());
        result = a%b;
        Console.WriteLine($"Remainder of the Number is {result}");
    }
}