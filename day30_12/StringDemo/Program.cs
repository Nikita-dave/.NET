using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         string fname, lname;
//         fname = "Nikita";
//         lname = "Dave";

//         char[] letters = {'H','E','L','L','O'};
//         string[] sarray={"Hello","From","T","Point"};

//         string fullname = fname+" "+lname;
//         System.Console.WriteLine("Full Name: {0}",fullname);

//         //by using constructor {'H','E','L','L','O'}
//         string greetings = new string(letters);
//         System.Console.WriteLine("Greetings: {0}",greetings);

//         //methods returning string {"Hello","From","T","Point"}
//         string message = String.Join(" ",sarray);
//         System.Console.WriteLine("Message: {0}",message);

//         //formatting method to convert value
//         DateTime waiting = new DateTime(2012, 10, 10, 17,58,15);
//         string chat = String.Format("Message sent at {0:t} on {0:D}",waiting);
//         System.Console.WriteLine("Message: {0}",chat);

//         string str1 = "This is test";
//         string str2 = "This is test";

//         if(String.Compare(str1, str2) == 0)
//         {
//             Console.WriteLine(str1+" and "+str2+" are equal,");
//         }
//         else
//         {                
//             System.Console.WriteLine(str2+" and "+str2+" are not equal.");
//         }

//         string str = "This is test";
//         if (str.Contains("test"))
//         {
//             System.Console.WriteLine("The sequence 'test' was found.");
//         }
//         // Console.ReadKey();

//         string s = "Last night I dreamt of San Pedro";
//         System.Console.WriteLine(s);
//         string substr = s.Substring(23);
//         System.Console.WriteLine(substr);
//         // Console.ReadKey();

//         System.Console.WriteLine("\"Hello World\"");
//         System.Console.WriteLine("D:\\Projects\\csharp\\Program.cs");
//         System.Console.WriteLine(@"D:\Projects\csharp\Program.cs");

//         var msg = @"Hello Alice,

//         Good Morning!
        
//         Your files have been saved to this location.
//         \shared\alice
        
//         Thanks.";
//         System.Console.WriteLine(msg);

//         var name = "Alice";
//         var greeting = String.Format("Hello {0}, {1}!",name,"good morning");
//         System.Console.WriteLine(greeting);

//         var name2 ="Alice";
//         var greet = "good morning";
//         var greeting2 = $"Hello {name2}, {greet}!";
//         System.Console.WriteLine(greeting);

//         var num = 12;
//         System.Console.WriteLine($"Square of {num} = {num * num}");

//         var text1 = "Hello World";
//         var sub_text = text1.Substring(6, 5);
//         var text = "   Hello World   ";
//         System.Console.WriteLine(sub_text);
//         System.Console.WriteLine(text.ToUpper());
//         System.Console.WriteLine(text.ToLower());
//         System.Console.WriteLine(text.Trim());
//         var csv = "Alice,bob,Chris,Dave,Eric,Fred";
//         var names = csv.Split(',');
//         for(var i = 0; i < names.Length; i++)
//         {
//             System.Console.WriteLine(names[i]);
//         }        

//         var g = "Hello Alice. Welcome";
//         var index = g.IndexOf("el");
//         var index1 = g.LastIndexOf("el");
//         System.Console.WriteLine(index);
//         System.Console.WriteLine(index1);
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         int[][] jagged_arr = new int[4][];
//         jagged_arr[0] = new int[] {1,2,3,4};
//         jagged_arr[1] = new int[] {11,22,34};
//         jagged_arr[2] = new int[] {12,34};
//         jagged_arr[3] = new int[] {42,54,67,27,59};

//         for(int i = 0; i < jagged_arr.Length; i++)
//         {
//             System.Console.Write("Row({0}): ",i);
//             for(int j = 0; j < jagged_arr[i].Length; j++)
//             {
//                 System.Console.Write("{0} ",jagged_arr[i][j]);
//             }
//             System.Console.WriteLine();
//         }
//     }
// }

class Program
{
    public static void Main(string[] args)
    {
        //1
        // string name;
        // name = Console.ReadLine();
        // System.Console.WriteLine(name);

        //2
        // string[] names = new string[10];
        // for(int i = 0; i < names.Length; i++)
        // {
        //     names[i] = Console.ReadLine();
        //     System.Console.WriteLine(names[i]);
        // }
        // for(int i = 0; i < names.Length; i++)
        // {
        //     System.Console.WriteLine(names[i]);
        // }

        //3
        // int[,] arr = new int[2,2];
        // for(int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for(int j = 0; j < arr.GetLength(1); j++)
        //     {
        //         arr[i,j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // } 

        // for(int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for(int j = 0; j < arr.GetLength(1); j++)
        //     {
        //         System.Console.Write(" "+arr[i,j]);
        //     }
        //     System.Console.WriteLine();
        // } 

        //4
        // System.Console.WriteLine("Enter rows: ");
        // int r = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Enter col: ");
        // int c = int.Parse(Console.ReadLine());
        // int[,] arr1 = new int[r,c];
        // int[,] arr2 = new int[r,c];
        // int[,] sum = new int[r,c];
        // System.Console.WriteLine("Enter arr1: ");
        // for(int i = 0; i < r; i++)
        // {
        //     for(int j = 0; j < c; j++)
        //     {
        //         arr1[i,j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }
        // System.Console.WriteLine("Enter arr2: ");
        // for(int i = 0; i < r; i++)
        // {
        //     for(int j = 0; j < c; j++)
        //     {
        //         arr2[i,j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // for(int i = 0; i < r; i++)
        // {
        //     for(int j = 0; j < c; j++)
        //     {
        //         sum[i,j] = arr1[i,j]+arr2[i,j];
        //     }
        // }
        // System.Console.WriteLine("Sum Matrix is: ");
        // for(int i = 0; i < r; i++)
        // {
        //     for(int j = 0; j < c; j++)
        //     {
        //         System.Console.Write($"{sum[i,j]} ");
        //     }
        //     System.Console.WriteLine();
        // }

        //5
        // System.Console.Write("Input the number of elements to be stored in the array :");
        // int l = Convert.ToInt32(Console.ReadLine());
        // int[] arr = new int[l];

        // for(int i = 0; i < l; i++)
        // {
        //     System.Console.Write($"Element {i}: ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Array.Sort(arr);
        // System.Console.WriteLine($"Largest: {arr[l-1]} ");
        // System.Console.WriteLine($"Smallest: {arr[0]} ");

        //6
        // System.Console.WriteLine("Enter rows1: ");
        // int r1 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Enter col1: ");
        // int c1 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Enter rows2: ");
        // int r2 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Enter col2: ");
        // int c2 = int.Parse(Console.ReadLine());
        // int[,] arr1 = new int[r1,c1];
        // int[,] arr2 = new int[r2,c2];
        // int[,] mul = new int[r1,c2];
        // System.Console.WriteLine("Enter arr1: ");
        // for(int i = 0; i < r1; i++)
        // {
        //     for(int j = 0; j < c1; j++)
        //     {
        //         arr1[i,j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }
        // System.Console.WriteLine("Enter arr2: ");
        // for(int i = 0; i < r2; i++)
        // {
        //     for(int j = 0; j < c2; j++)
        //     {
        //         arr2[i,j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // for(int i = 0; i < r1; i++)
        // {
        //     for(int j = 0; j < c2; j++)
        //     {
        //         mul[i,j]=0;
        //         for(int k = 0; k <c1; j++)
        //         {
        //             mul[i,j] += arr1[i,k]*arr2[k,j];
        //         }
        //     }
        // }

        // System.Console.WriteLine("Sum Multiplication is: ");
        // for(int i = 0; i < r1; i++)
        // {
        //     for(int j = 0; j < c2; j++)
        //     {
        //         System.Console.Write($"{mul[i,j]} ");
        //     }
        //     System.Console.WriteLine();
        // }

        //7
        // System.Console.WriteLine("Enter rows: ");
        // int r = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Enter col: ");
        // int c = int.Parse(Console.ReadLine());
        // int[,] arr = new int[r,c];
        // System.Console.WriteLine("Enter arr1: ");
        // for(int i = 0; i < r; i++)
        // {
        //     for(int j = 0; j < c; j++)
        //     {
        //         arr[i,j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        //10
        // System.Console.WriteLine("Enter String: ");
        // string str = Console.ReadLine();
        // string rev ="";
        // for(int i = str.Length-1;i>=0; i--)
        // {
        //     rev+=str[i];
        // }
        // System.Console.WriteLine("String after reversing: {0}",rev);

        //11
        // System.Console.WriteLine("Enter String: ");
        // string str = Console.ReadLine();
        // char[] arr = str.ToCharArray();
        // Array.Reverse(arr);
        // string rev = new string(arr);
        // System.Console.WriteLine("String after reversing: {0}",rev);

        //12
        // System.Console.WriteLine("Enter String: ");
        // string str = Console.ReadLine();
        // System.Console.WriteLine("String in upprcase: {0}",str.ToUpper());
        // System.Console.WriteLine("String in lowercase: {0}",str.ToLower());

        //13
        System.Console.WriteLine("Enter String: ");
        string str = Console.ReadLine();
        string upper="";
        string lower="";
        for(int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if(ch>='a'&& ch <= 'z')
            {
                upper+= (char)(ch-32);
            }
            else
            {
                upper+=ch; 
            }
            if(ch>='A'&& ch <= 'Z')
            {
                lower+= (char)(ch+32);
            }
            else
            {
                lower+=ch; 
            }
        }
        System.Console.WriteLine(upper);
        System.Console.WriteLine(lower);

        //14
        System.Console.WriteLine("Enter String1: ");
        string str1 = Console.ReadLine();
        System.Console.WriteLine("Enter String2: ");
        string str2 = Console.ReadLine();
        if (str1.Equals(str2))
        {
            System.Console.WriteLine("Equal");
        }
        else
        {
            System.Console.WriteLine("Not equal");
        }

        //15
        bool eq= true;
        for(int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                eq=false;
            }
        }
        if (eq == true)
        {
            System.Console.WriteLine("Equal");
        }
        else
        {
            System.Console.WriteLine("Not Equal");
        }

        //16
        string str3 = str1+" "+str2;
        System.Console.WriteLine(str3);

        //17
        System.Console.WriteLine(String.Concat(str1,str2));

        //18
        if (str1.Contains("hello"))
        {
            System.Console.WriteLine("found");
        }
        else
        {
            System.Console.WriteLine("not found");
        }
    }
}
