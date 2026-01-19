using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

// internal class Program
// {
//     //var m=0;
//     //dynamic n =10;
//     public static void Main(string[] args)
//     {
//         //Hah Table
//         // Hashtable hashtable = new Hashtable();
//         // hashtable.Add(100,"Rajesh");
//         // hashtable.Add(200,"Suresh");
//         // hashtable.Add(300,"Rakesh");
//         // hashtable.Add(400,"John");
//         // hashtable.Add(500,"David");

//         // ICollection key = hashtable.Keys;
//         // System.Console.WriteLine("All Keys are");
//         // foreach (var k1 in key)
//         // {
//         //     System.Console.WriteLine(k1);
//         // }
//         // ICollection value = hashtable.Values;
//         // System.Console.WriteLine("All values are");
//         // foreach (var v in value)
//         // {
//         //     System.Console.WriteLine(v);
//         // }

//         // foreach (var k1 in key)
//         // {
//         //     System.Console.WriteLine($"Key is {k1} and Value is {hashtable[k1]}");
//         // }

//         // System.Console.WriteLine("Search key and value");
//         // int k=Convert.ToInt32(Console.ReadLine());
//         // if (hashtable.ContainsKey(200))
//         // {
//         //     System.Console.WriteLine($"Found {k} with value {hashtable[k]}");
//         // }
//         // else
//         // {
//         //     System.Console.WriteLine("Not found");
//         // }

//         //SortedList
//         // SortedList list = new SortedList();
//         // list.Add(500,"Rajesh");
//         // list.Add(400,"Suresh");
//         // list.Add(300,"Rakesh");
//         // list.Add(200,"Mahesh");
//         // list.Add(100,"Ramesh");
//         // ICollection key = list.Keys;
//         // System.Console.WriteLine("All keys are");
//         // foreach (var k in key)
//         // {
//         //     System.Console.WriteLine(k);
//         // }
//         // ICollection value = list.Values;
//         // System.Console.WriteLine("All values are");
//         // foreach (var v in value)
//         // {
//         //     System.Console.WriteLine(v);
//         // }
//         // System.Console.WriteLine("All key and values are");
//         // foreach (var k in key)
//         // {
//         //     System.Console.WriteLine($"Key is {k} and Value is {list[k]}");
//         // }
//         // System.Console.WriteLine($"Key having Index {list.IndexOfKey(400)} and value having Index {list.IndexOfValue("Suresh")}");
//         // list.Clear();
//         // System.Console.WriteLine("All key and values after clearing");
//         // foreach (var k in key)
//         // {
//         //     System.Console.WriteLine($"Key is {k} and Value is {list[k]}");
//         // }  
//         // int count =list.Count;  
//         // System.Console.WriteLine($"Count is {count}"); 

//         //Stack

//         // Stack stack = new Stack();
//         // stack.Push('A');
//         // stack.Push('B');
//         // stack.Push('C');
//         // stack.Push('D');
//         // stack.Push('E');
//         // stack.Push('F');

//         // foreach (var item in stack)
//         // {
//         //     System.Console.WriteLine(item);
//         // }
//         // stack.Push('G');
//         // stack.Push('H');
//         // System.Console.WriteLine("\n\n");
//         // foreach (var item in stack)
//         // {
//         //     System.Console.WriteLine(item);
//         // }
//         // System.Console.WriteLine($"top element: {stack.Peek()}");

//         // stack.Pop();
//         // stack.Pop();
//         // stack.Pop();
//         // stack.Pop();
//         // System.Console.WriteLine("After removing top element");
//         // foreach (var item in stack)
//         // {
//         //     System.Console.WriteLine(item);
//         // }
//         // System.Console.WriteLine("Enter element to find");
//         // char ch = Convert.ToChar(Console.ReadLine());
//         // if (stack.Contains(ch))
//         // {
//         //     System.Console.WriteLine($"Element {ch} Found");
//         // }
//         // else
//         // {
//         //     System.Console.WriteLine($"Element Not Found");
//         // }

//         //Queue
//         // Queue queue = new Queue();
//         // queue.Enqueue('A');
//         // queue.Enqueue('B');
//         // queue.Enqueue('C');
//         // queue.Enqueue('D');
//         // queue.Enqueue('E');

//         // foreach (var q in queue)
//         // {
//         //     System.Console.WriteLine($"{q}");
//         // }
//         // queue.Dequeue();
//         // System.Console.WriteLine("\n\nAfter Deleting from queue");
//         // foreach (var q in queue)
//         // {
//         //     System.Console.WriteLine($"{q}");
//         // }    

//         // object o;
//         // int i=10;
//         // o=i;//boxing
//         // int j = (int)o; //unboxing   

//         // ArrayList list = new ArrayList();
//         // //boxing
//         // list.Add(10);
//         // list.Add(false);
//         // list.Add(60.5f);

//         // //unboxing
//         // int k=(int)list[10];
//         // var v = list[1];
//         // bool t = (bool)v;
//         // // var x=0;
//         // // x="Hello";

//         // dynamic d=10;
//         // d = "Hello"; 

//         // AddClass addClass = new AddClass();
//         // int sumInt=addClass.AddInt(30,20);
//         // System.Console.WriteLine($"Sum of integer is {sumInt}");

//         // float sumFloat=addClass.AddFloat(30.15f,20.15f);
//         // System.Console.WriteLine($"float sum {sumFloat}");

//         // string concat = addClass.AddString("helllo ","World");
//         // System.Console.WriteLine($"string concat {concat}");

//         // AddGenericClass<int> addInt = new AddGenericClass<int>();
//         // int sumInt1 = addInt.AddAllType(30,20);
//         // System.Console.WriteLine($"Sum of integer is {sumInt1}");

//         // AddGenericClass<float> addFloat = new AddGenericClass<float>();
//         // float sumFloat1=addFloat.AddAllType(30.15f,20.15f);
//         // System.Console.WriteLine($"float sum {sumFloat1}");

//         // AddGenericClass<string> addstring = new AddGenericClass<string>();
//         // string concat1 = addstring.AddAllType("helllo ","World");
//         // System.Console.WriteLine($"string concat {concat1}");

//         // AddGenericClass<int> addInteger1 = new AddGenericClass<int>(20,30);

//     }
// }

class Program
{
    private static void Main(string[] args)
    {
        // AddClass addClass = new AddClass();
        // int sumInt=addClass.AddInt(30,20);
        // System.Console.WriteLine($"Sum of integer is {sumInt}");

        // float sumFloat=addClass.AddFloat(30.15f,20.15f);
        // System.Console.WriteLine($"float sum {sumFloat}");

        // string concat = addClass.AddString("helllo ","World");
        // System.Console.WriteLine($"string concat {concat}");

        // AddGenericClass<int> addInt = new AddGenericClass<int>();
        // int sumInt1 = addInt.AddAllType(30,20);
        // System.Console.WriteLine($"Sum of integer is {sumInt1}");

        // AddGenericClass<float> addFloat = new AddGenericClass<float>();
        // float sumFloat1=addFloat.AddAllType(30.15f,20.15f);
        // System.Console.WriteLine($"float sum {sumFloat1}");

        // AddGenericClass<string> addstring = new AddGenericClass<string>();
        // string concat1 = addstring.AddAllType("helllo ","World");
        // System.Console.WriteLine($"string concat {concat1}");

        // AddGenericClass<int> addInteger1 = new AddGenericClass<int>(20,30);

        // List<string> empName = new List<string>();
        // empName.Add("Rajesh");
        // Employee employee1 = new Employee()
        // {
        //     Id=10,
        //     Name="Rajesh"
        // };
        // Employee employee2 = new Employee()
        // {
        //     Id=20,
        //     Name="Ramesh"
        // };

        // List<Employee> employees = new List<Employee>();
        // employees.Add(employee1);
        // employees.Add(employee2);

        // foreach (Employee e in employees)
        // {
        //     System.Console.WriteLine(e);
        // }

        // Dictionary<int, string> directory = new Dictionary<int, string>();
        // directory.Add(100,"Nikita");
        // directory.Add(200,"Mahesh");

        // foreach (KeyValuePair<int, string> key in directory)
        // {
        //     System.Console.WriteLine($"key is  {key.Key} Value is {key.Value}");
        // }

        // SortedList<string,string> pairs = new SortedList<string,string>();
        // pairs.Add("100","Rajesh");
        // pairs.Add("200","suresh");
        // pairs.Add("300","mahesh");
        // System.Console.WriteLine("\n\nGeneric sorted list");
        // foreach (KeyValuePair<string,string> key in pairs)
        // {
        //     System.Console.WriteLine($"Key is {key.Key} Value is {key.Value}");
        // }

        // Stack<char> stack = new Stack<char>();
        // stack.Push('A');
        // stack.Push('B');
        // stack.Push('C');
        // stack.Push('D');
        // stack.Push('E');
        // System.Console.WriteLine("Generic stack");
        // foreach (var item in stack)
        // {
        //     System.Console.WriteLine(item);
        // }

        // Queue<char> queue = new Queue<char>();
        // queue.Enqueue('A');
        // queue.Enqueue('B');
        // queue.Enqueue('C');
        // queue.Enqueue('D');
        // queue.Enqueue('E');

        // foreach (var q in queue)
        // {
        //     System.Console.WriteLine($"{q}");
        // }
        // queue.Dequeue();
        // System.Console.WriteLine("\n\nAfter Deleting from queue");
        // foreach (var q in queue)
        // {
        //     System.Console.WriteLine($"{q}");
        // }  
        
        MyCollection obj = new MyCollection();
        foreach (int i in obj)
        {
            System.Console.WriteLine(i);
        }
    }
}

