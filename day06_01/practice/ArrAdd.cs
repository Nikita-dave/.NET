using System;

class ArrAdd
{
    public static void Add()
    {
        try
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            int[] array1 = new int[arr1.Length];
            for(int i = 0; i < arr1.Length; i++)
            {
                array1[i]=Convert.ToInt32(arr1[i]);
            }
            string[] arr2 = Console.ReadLine().Split(' ');
            int[] array2 = new int[arr2.Length];
            for(int i = 0; i < arr2.Length; i++)
            {
                array2[i]=Convert.ToInt32(arr2[i]);
            }
            if (array1.Length != array2.Length)
            {
                System.Console.WriteLine("Error: Arrays must have the same length for addition.");
                return;
            }
            int[] sumArr3 = new int[array1.Length];
            for(int i = 0; i < array1.Length; i++)
            {
                sumArr3[i]=array1[i]+array2[i];
            }
            int index = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine($"Element at index {index} int hte sum array: {sumArr3[index]}");

        }
        catch(FormatException e)
        {
            System.Console.WriteLine("Error: Invalid input format. Please enter integers only.");
            System.Console.WriteLine($"Exception: {e.Message}");
        }
        catch(IndexOutOfRangeException e)
        {
            System.Console.WriteLine("Error: Index out of range for the sum array.");
            System.Console.WriteLine($"Exception: {e.Message}");
        }
    }
}