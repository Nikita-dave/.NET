using System;
using System.IO;

class BinaryReadExample
{
    public static void Solve()
    {
        string filePath ="employee.dat";
        using (FileStream fs = new FileStream(filePath,FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int  id = reader.ReadInt32();
            string name = reader.ReadString();
            double salary = reader.ReadDouble();
            bool isActive = reader.ReadBoolean();

            System.Console.WriteLine($"ID: {id}");
            System.Console.WriteLine($"Name: {name}");
            System.Console.WriteLine($"Salary: {salary}");
            System.Console.WriteLine($"Active: {isActive}");
        }

    }
}