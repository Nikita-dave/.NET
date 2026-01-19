using System;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        Employee employee1 = new Employee(){Id=10,Name="Nikita"};
        Employee employee2 = new Employee(){Id=20, Name="Rajesh"};
        Employee employee3 = new Employee(){Id=30, Name="Suresh"};
        list.Add(30);
        list.Add(40);
        list.Add(10);
        list.Add(20);  
        list.Add(50);
        list.Add(60.45f);
        list.Add(false);
        list.Add(employee1);
        list.Add(employee2);
        list.Add(employee3);
        System.Console.WriteLine($"Count of Array List is {list.Count}");

        System.Console.WriteLine("List before adding range: ");
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }
        ArrayList list1 = new ArrayList();
        list1.Add(70);
        list1.Add(60);
        list1.Add(80);
        list.AddRange(list1);
        System.Console.WriteLine("List after adding range: ");
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        } 
        System.Console.WriteLine($"Count of Array List is {list.Count}"); 
        // list.Clear();
        // System.Console.WriteLine($"Count of Array List after clearing is {list.Count}"); 
        // System.Console.WriteLine("List after clearing range: ");
        // foreach (var item in list)
        // {
        //     System.Console.WriteLine(item);
        // }
        System.Console.WriteLine(list.Contains(40));
        if (list.Contains(50))
        {
            System.Console.WriteLine($"Object 50 is at index no {list.IndexOf(50)}");
        }
        else
        {
            System.Console.WriteLine("not found");
        }    

        list.RemoveAt(5);
        list.Remove(false);
        list.RemoveRange(5,3);
        list.Sort();
        System.Console.WriteLine("List after removing elements: ");
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        } 
        list.Reverse();
        System.Console.WriteLine("List after reversing elements: ");
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        } 
        list.Insert(0,90);
        list.Insert(3,65);
        System.Console.WriteLine("List after inserting elements: ");
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }
        ArrayList list2 = new ArrayList();
        list2.Add(46);
        list2.Add(47);
        list2.Add(48);
        list.InsertRange(5,list2);
        System.Console.WriteLine("List after inserting range in the list: ");
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }
    }

}


