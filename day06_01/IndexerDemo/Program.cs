using System;

class Program
{
    public static void Main(string[] str)
    {
        // Employee employee = new Employee();
        // employee[0]= "String 1";
        // employee[1]= "String 2";
        // employee[2]= "String 3";
        // employee[3]= "String 4";
        // employee[4]= "String 5";

        // for(int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine(employee[i]);
        // }
        // System.Console.WriteLine("Value at index {0}: ",employee[3]);
        // System.Console.WriteLine("String 4 is at index: {0}",employee["String 4"]);

        // int a=0;
        // int b=0;
        // int result=0;
        // int[] arr = new int[6]{10,20,30,40,50,60};

        // try
        // {
        //     a=Convert.ToInt32(Console.ReadLine());
        //     b=Convert.ToInt32(Console.ReadLine());
        //     result = a/b;
        //     for (int i = 0; i <9; i++)
        //     {
        //         System.Console.WriteLine(arr[i]);
        //     }
        // }
        // catch(IndexOutOfRangeException ex)
        // {
        //     System.Console.WriteLine($"Index is out of range {ex.Message}");
        // }
        // catch (DivideByZeroException ex)
        // {
        //     System.Console.WriteLine($"cannot divide number by zero {ex.Message.ToString()}");
        // }
        // catch(FormatException ex)
        // {
        //     System.Console.WriteLine($"enter number only {ex.Message}");
        // }
        // catch(Exception ex)
        // {
        //     System.Console.WriteLine(ex.Message);
        // }
        // finally
        // {
        //     System.Console.WriteLine($"Division of {a} and {b} is {result}");
        // }

        try
        {
            throw new MyException("Rajesh");
        }
        catch(Exception e)
        {
            System.Console.WriteLine("Exception caught "+e.ToString());
        }
        System.Console.WriteLine("LAST STATEMENT");
    }
}