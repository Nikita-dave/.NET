using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SerializeExample
{
    public static void Main(string[] args)
    {
        FileStream stream = new FileStream("Student.txt",FileMode.Create);
    }
}