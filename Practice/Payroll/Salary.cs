using System;

class Salary
{
    public void Swap(int s1, int s2)
    {
        int temp;
        temp = s1;
        s1 = s2;
        s2 = temp;
        Console.WriteLine($"Inside Swap Method: After Swaping {s1} and {s2}");
    }
}