using System;
using System.IO;
class BinaryWriteExample
{
    public static void Solve1()
    {
        string filePath = "employee.dat";
        using (FileStream fs = new FileStream(filePath,FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(101);         //int
            writer.Write("Nikita");    //string 
            writer.Write(45000.75);    //double
            writer.Write(true);        //bool
        }
        System.Console.WriteLine("Binary file written successfully.");
    }
}
