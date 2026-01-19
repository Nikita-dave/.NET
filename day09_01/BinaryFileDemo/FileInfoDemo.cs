using System;
using System.IO;

class FileInfoDemo
{
    public static void Main()
    {
        // string path = @"MyTestFile.txt";
        // FileInfo f1 = new FileInfo(path);
        // File.Create(path);
        // {
        //     System.Console.WriteLine("File has been created");
        // }

        // FileInfo f1  = new FileInfo(@"MyTestFilecreatetext2.txt");
        // StreamWriter str = f1.CreateText();
        // str.WriteLine("hello");
        // System.Console.WriteLine("File has been created with text");
        // str.Close(); 

        //delete an existing file
        // FileInfo f1  = new FileInfo(@"MyTestFilecreatetext2.txt");
        // f1.Delete();
        // System.Console.WriteLine("File has been deleted");

        //copy an existing file into a new file
        // string path1 = @"MyTestFile.txt";
        // string path2 = @"NewFile.txt";
        // FileInfo f1 = new FileInfo(path1);
        // FileInfo f2 = new FileInfo(path2);
        // f1.CopyTo(path2);
        // System.Console.WriteLine("{0} was copied to {1}.",path1,path2);

        //move file from one place to another
        // string path1 = @"NewFile1.txt";
        // string path2 = @"NewFile2.txt";
        // FileInfo f1 = new FileInfo(path1);
        // FileInfo f2 = new FileInfo(path2);
        // f1.MoveTo(path2);
        // System.Console.WriteLine("{0} was moved to {1}.",path1,path2);

        //append text to a file
        // FileInfo f1 = new FileInfo(@"NewFile2.txt");
        // StreamWriter sw = f1.AppendText();
        // sw.WriteLine("This");
        // sw.WriteLine("is Extra");
        // sw.WriteLine("Text");
        // System.Console.WriteLine("File has been appended");
        // sw.Close();

        //creates a streamreader with utf8 encoding that reads from an existing text file
        // FileInfo f1 = new FileInfo(@"NewFile2.txt");
        // StreamReader sr = f1.OpenText();
        // string s = "";
        // while ((s = sr.ReadLine()) != null)
        // {
        //     System.Console.WriteLine(s);
        // }

        FileInfo f1 = new FileInfo("NewFile2.txt");
        System.Console.WriteLine("File name is {0}",f1.Name);
        System.Console.WriteLine("File creation time is {0}",f1.CreationTime.ToLongTimeString());
        System.Console.WriteLine("File creation time is {0}",f1.CreationTime);
        System.Console.WriteLine("File last access time is {0}",f1.LastAccessTime.ToLongDateString());
        System.Console.WriteLine("File last access time is {0}",f1.LastAccessTime);
        System.Console.WriteLine("File length is {0}",f1.Length.ToString()+" bytes");
        System.Console.WriteLine("File extension is {0}",f1.Extension);
        System.Console.WriteLine("File exist is: {0}",f1.Exists);

    }
}