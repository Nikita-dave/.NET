using System;
using System.Globalization;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        StringBuilder sb1 = new StringBuilder("Hello World");
        for(int i = 0; i < sb1.Length; i++)
        {
            System.Console.Write(sb1[i]);
        }
        System.Console.WriteLine();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("World!");
        sb.Append("Hello ");
        sb.AppendLine("World!");
        sb.AppendLine("Hello C#");
        System.Console.Write(sb);

        StringBuilder sbAmount = new StringBuilder("Your total amount is ");
        sbAmount.AppendFormat("{0:C} ",25);

        CultureInfo india = new CultureInfo("en-IN");
        sbAmount.AppendFormat(india,"{0:C}",12345678);
        System.Console.WriteLine(sbAmount);

        StringBuilder sb2 = new StringBuilder("Hello World!");
        sb2.Insert(5," C#");
        System.Console.WriteLine(sb2);
        StringBuilder sb3 = new StringBuilder("Hello World!",50);
        sb3.Remove(6, 6);
        System.Console.WriteLine(sb3);
    }
}

