using System;
class MyException : Exception
{
    public MyException(string str)
    {
        System.Console.WriteLine("User defined exception");
    }
}