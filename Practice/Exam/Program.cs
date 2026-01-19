using System;

class Exam
{
    public static void Main(string [] arg)
    {
        int n1=40;
        int n2=50;
        int sum=0;
        int n3=0;
        int n4=0;
        Number number = new Number();
        number.Addition(n1,n2,out sum,out n3,out n4);
        Console.WriteLine($"First Number is : {n3}, Second number is: {n4}");
        Console.WriteLine($"Addition is : {sum}");
    }
}