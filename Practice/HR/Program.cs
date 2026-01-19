using System;

class HR
{
    public static void Main(string[] arg)
    {
        int n1 = 100;
        int n2 = 200;
        Console.WriteLine($"Numbers before swapping: n1 = {n1}, n2 = {n2}");
        Ref reference = new Ref();
        reference.Swap(ref n1, ref n2);
        Console.WriteLine($"Numbers after swapping: n1 = {n1}, n2 = {n2}");
    }
}
