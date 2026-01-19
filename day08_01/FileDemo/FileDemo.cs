class FileDemo
{
    public void WriteTextData()
    {
        FileStream fileStream = new FileStream(@"d:\Data\Test.txt",FileMode.Append,FileAccess.Write);
        StreamWriter streamWriter = new StreamWriter(fileStream);
        System.Console.WriteLine("Enter Some Text: ");
        string str= Console.ReadLine();
        streamWriter.WriteLine(str);
        
        streamWriter.Close();
        fileStream.Close();
    }
    public void ReadTextData()
    {
        FileStream fileStream = new FileStream(@"d:\Data\Test.txt",FileMode.Open,FileAccess.Read);
        StreamReader streamReader = new StreamReader(fileStream);
        streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
        string str= streamReader.ReadLine();
        while(str!= null)
        {
            Console.WriteLine(str);
            str=streamReader.ReadLine();
        }
        Console.ReadLine();
        streamReader.Close();
        fileStream.Close();
    }

}