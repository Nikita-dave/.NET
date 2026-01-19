using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        // FileStream fileStream = new FileStream(@"d:\Data\Test.txt",FileMode.Open,FileAccess.Write);
        // StreamWriter streamWriter = new StreamWriter(fileStream);
        // System.Console.WriteLine("Enter Some Text: ");
        // string str= Console.ReadLine();
        // streamWriter.WriteLine(str);

        // streamWriter.Close();
        // fileStream.Close();

    
        // FileStream fileStream = new FileStream(@"d:\Data\Test.txt",FileMode.Append,FileAccess.Write);
        // StreamWriter streamWriter = new StreamWriter(fileStream);
        // System.Console.WriteLine("Enter Some Text: ");
        // string str= Console.ReadLine();
        // streamWriter.WriteLine(str);
        
        // streamWriter.Close();
        // fileStream.Close();

        FileDemo filedemo = new FileDemo();
        // filedemo.WriteTextData();
        filedemo.ReadTextData();
    }
    
}
