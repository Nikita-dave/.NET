using System;
namespace Arrays;
class Program
{
    public static void Main(string[] args)
    {
        // int[] arr; //array declaration
        // arr = new int[6]; //array initialization
        //assigning values to it
        // arr[0]=10; //arr[0] index number start with 0
        // arr[1]=20;
        // arr[2]=30;
        // arr[3]=40;
        // arr[4]=50;
        // arr[5]=60;

        // System.Console.WriteLine("Enter length of an array");
        // int length = Convert.ToInt32(Console.ReadLine());
        // arr = new int[length];

        // for(int i = 0; i < arr.Length; i++)
        // {
        //     System.Console.WriteLine($"Enter Element at Index {i}: ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // // int length = arr.Length;
        // // int length = arr.GetLength(0);
        // System.Console.WriteLine("Length of an array is {0}",length);

        // for(int i = 0; i < arr.Length; i++)
        // {
        //     System.Console.WriteLine($"Element at {i} index is {arr[i]}");
        // }

        // foreach(int i in arr)
        // {
        //     System.Console.WriteLine($"Element is {i}");
        // }

        // char[] ch = new char[11]{'H','E','L','L','O','W','O','R','L','D','\0'};
        // char[] ch1 = new char[10];
        // System.Console.WriteLine("Enter character");
        // for(int i = 0; i < ch1.Length; i++)
        // {
        //     ch1[i] = Convert.ToChar(Console.ReadLine());
        // }
        // for(int i = 0; i < ch1.Length; i++)
        // {
        //     Console.Write($"{ch1[i]}");
        // }
        // Console.WriteLine();
        // for(int i = 0; i < ch.Length; i++)
        // {
        //     Console.Write($"{ch[i]}");
        // }

        // string[] empNames = new string[6];
        // System.Console.WriteLine("Enter Employee Names");
        // for(int i = 0; i < empNames.Length; i++)
        // {
        //     empNames[i]=Console.ReadLine();
        // }
        // Console.WriteLine("Employee Name are ");
        // for(int i = 0; i < empNames.Length; i++)
        // {
        //      System.Console.WriteLine($"Employee at index {i} is {empNames[i]}");
        // }

        // Program program = new Program();
        // int[] arr = {10,20,30,40,50,60};
        // // program.PassArrayDemo(arr);
        // int[] arr1 = [0];
        // arr1 = program.ReturnArrayDemo(6);

        // System.Console.WriteLine("Element return from array are: ");
        // for(int i = 0; i < arr1.Length; i++)
        // {
        //     System.Console.WriteLine($"Element at {i} index is {arr1[i]}");
        // }

        // int[,] arr = new int[3,3];
        // arr[0,0]=10;
        // arr[0,1]=20;
        // arr[0,2]=30;
        // arr[1,0]=40;
        // arr[1,1]=50;
        // arr[1,2]=60;
        // arr[2,0]=70;
        // arr[2,1]=80;
        // arr[2,2]=90;

        // System.Console.WriteLine("Elements in 3*3 matrix is ");
        // for(int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for(int j = 0; j < arr.GetLength(1); j++)
        //     {
        //         System.Console.Write($"{arr[i,j]} ");
        //     }
        //     System.Console.WriteLine();
        // }

        // int k=0;
        // int l=0;
        // System.Console.WriteLine("Enter number of rows");
        // k=Convert.ToInt32(Console.ReadLine());
        // System.Console.WriteLine("Enter number of column");
        // l=Convert.ToInt32(Console.ReadLine());
        // System.Console.WriteLine($"Enter Element in {k} x {l} matrix is");
        // int[,] arr2= new int[k,l];
        // for(int i = 0; i < arr2.GetLength(0); i++)
        // {
        //     for(int j = 0; j < arr2.GetLength(1); j++)
        //     {
        //         System.Console.Write($"Enter Element at {i} of {j} ");
        //         arr2[i,j]=Convert.ToInt32(Console.ReadLine());
        //     }
        //     System.Console.WriteLine();
        // }

        // Console.WriteLine("\n\n");
        // System.Console.WriteLine($"Element in {k} x {l} matrix is");
        // for(int i = 0; i < arr2.GetLength(0); i++)
        // {
        //     for(int j = 0; j < arr2.GetLength(1); j++)
        //     {
        //         System.Console.Write($"{arr2[i,j]} ");
        //     }
        //     System.Console.WriteLine();
        // }



        int[] arr = new int[6]{50,20,30,10,40,60};

        System.Console.WriteLine($"Array Index of value 60 {Array.IndexOf(arr,60)}");
        System.Console.WriteLine($"Array value at index 3 {arr.GetValue(3)}");
        System.Console.WriteLine($"Array is Fixedsize {arr.IsFixedSize}");
        System.Console.WriteLine($"Array is Readonly {arr.IsReadOnly}");
        System.Console.WriteLine($"Array is Rank {arr.Rank}");

        System.Console.WriteLine("\n\n");
        System.Console.WriteLine("After reversing");
        Array.Reverse(arr);
        for(int i = 0; i < arr.Length; i++)
        {
            System.Console.WriteLine(arr[i]);
        }

        Employee employee1 = new Employee(){Id=30, Name="Rajesh"};
        Employee employee2 = new Employee(){Id=40, Name="Suresh"};
        Employee employee3 = new Employee(){Id=20, Name="Ramesh"};
        Employee employee4 = new Employee(){Id=60, Name="Jayesh"};
        Employee employee5 = new Employee(){Id=10, Name="Ganesh"};
        Employee[] employeeList = new Employee[5];
        employeeList[0] = employee1;
        employeeList[1] = employee2;
        employeeList[2] = employee3;
        employeeList[3] = employee4;
        employeeList[4] = employee5;

        System.Console.WriteLine("Before sorting");
        foreach(Employee e in employeeList)
        {
            System.Console.WriteLine(e);
        }
        Array.Sort(employeeList);
        System.Console.WriteLine("After Sorting");
        foreach(Employee e in employeeList)
        {
            System.Console.WriteLine(e);
        }

        Program program = new Program();
        Employee employee = new Employee
        {
            Id=90,
            Name="Nikita Dave"
        };
        program.PassObject(employee);

        Employee employee6 = program.ReturnObject();
        System.Console.WriteLine(employee6);

        program.PassArrayObject(employeeList);

    }

    public void PassObject(Employee employee)
    {
        System.Console.WriteLine(employee);
    }

    public Employee ReturnObject()
    {
        Employee employee = new Employee
        {
            Id=120,
            Name = "Ramesh Kumar"
        };
        return employee;
    }

    public void PassArrayObject(Employee[] employee)
    {
        foreach(Employee e in employee)
        {
            System.Console.WriteLine(e);
        }
    }



    // public static void PassArrayDemo(int[] arr)
    // {
    //     int sum=0;
    //     for(int i = 9; i < arr.Length; i++)
    //     {
    //         sum+=arr[i];
    //     }
    //     System.Console.WriteLine("Sum of all array is {0}",sum);
    // }

    // public int[] ReturnArrayDemo(int length)
    // {
    //     int[] arr = new int[length];
    //     System.Console.WriteLine(($"Enter {length} number of elements" ));
    //     for(int i = 0; i < arr.Length; i++)
    //     {
    //         arr[i]=Convert.ToInt32(Console.ReadLine());
    //     }
    //     return arr;
    // }
}
