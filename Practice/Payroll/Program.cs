using System;

class Payroll
{
    public static void Main(string[] args){
    Salary salary = new Salary();
        int s1 = 30;
        int s2 =  20;
        Console.WriteLine($"Before Swaping {s1} and {s2}");
        salary.Swap(s1,s2);
        Console.WriteLine($"After Swaping {s1} and {s2}");
}
}
