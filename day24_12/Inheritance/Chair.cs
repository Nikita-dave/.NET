using System;

class Chair: Furniture
{
    public override void Accept()
    {
        System.Console.WriteLine("enter no of chairs");
        num=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("enter color");
        color=Convert.ToString(Console.ReadLine());
        System.Console.WriteLine("enter width");
        width=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("enter height");
        height=Convert.ToInt32(Console.ReadLine());
    }

    public override void Display()
    {
        Console.WriteLine("num of chairs are: {0} ",num);
        Console.WriteLine("Color is: {0} ",color);
        Console.WriteLine("Height is: {0} ",height);
        Console.WriteLine("Width is: {0} ",width);

    }
}