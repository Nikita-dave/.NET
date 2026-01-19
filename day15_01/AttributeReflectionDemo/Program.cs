using System;
using System.Reflection;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Rectangle rec = new Rectangle(30,20);
//         rec.GetArea();
//         rec.Display();
//     }
// }

//Initialise t as typeof string
Type t = typeof(string);

//Use Reflection
System.Console.WriteLine("Name : {0}", t.Name);
System.Console.WriteLine("Full Name : {0}", t.FullName);
System.Console.WriteLine("Namespace : {0}", t.Namespace);
System.Console.WriteLine("Base Type : {0}", t.BaseType);



// Declare Instance of class Assembly
// Call the GetExecutingAssembly method
// to load the current assembly
Assembly executing = Assembly.GetExecutingAssembly();

// Array to store types of the assembly
Type[] types = executing.GetTypes();
foreach (var item in types)
{
    // Display each type
    Console.WriteLine("Class : {0}", item.Name);

    // Array to store methods
    MethodInfo[] methods = item.GetMethods();
    foreach (var method in methods)
    {
        // Display each method
        Console.WriteLine("--> Method : {0}", method.Name);

        // Array to store parameters
        ParameterInfo[] parameters = method.GetParameters();
        foreach (var arg in parameters)
        {
            // Display each parameter
            Console.WriteLine("----> Parameter : {0} Type : {1}",
                                    arg.Name, arg.ParameterType);
        }
    }
}

