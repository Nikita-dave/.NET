using System;

class Calculator
{
    //Method overloading

    public int Add()//Method with no parameter
    {
        int num1=30;
        int num2=50;
        return num1+num2;
    }

    // public int Add()//  Error implementing polymorphism
    // {
    //     int num1=30;
    //     int num2=50;
    //     return "";
    // }

    public int Add(int n)//Method with one parameter
    {
        int num1=30;
        int num2=n;
        return num1+num2;
    }

    public int Add(int n1, int n2)//Method with two parameter
    {
        int num1=n1;
        int num2=n2;
        return num1+num2;
    }

    public int Add(string str1, string str2)//Method with one parameter
    {
        string str3 = str1+str2;
        Console.WriteLine($"Concatenated string is {str3}");
        return 0;
    }

    public int Add(string str1, float flt, int num)//Method with one parameter
    {
        Console.WriteLine($"String is {str1} \n Float is {flt}\n integer is {num}");
        return 0;
    }
}