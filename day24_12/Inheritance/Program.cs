using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main(string[] arg)
    {
        //object initializer
        // Employee employee = new Employee
        // {
        //     EmployeeId=101,
        //     Name = "Rajesh",
        //     Salary= 750000
        // };


        // Console.WriteLine($"Employee Id is {employee.EmployeeId}");
        // Console.WriteLine($"Employee Name is {employee.Name}");
        // Console.WriteLine($"Employee salary is {employee.Salary}");

        // Console.WriteLine($"{employee}");

        // Program program = new Program();
        // int[] arr =[10,20,30,40,50,60,70,80,90];
        // program.Add(arr);

        // Calculator calculator = new Calculator();
        // calculator.Add(10);
        // calculator.Add("Hello", "World");

        // double distance=50.00;
        // double hour=5.0;
        // double fuel=10.0;
        // Vehicle vehicle = new Vehicle(distance,hour,fuel); //creatong the object of base class
        // vehicle.Average(); //calling base class member method
        // vehicle.Speed();

        // Car car = new Car(distance,hour,fuel);
        // car.Average();
        // car.Speed();

        // Furniture furniture = new Furniture(); //Error cannot create an object of abstract class

        //Furniture furniture; // can create a reference variable

        // Bookshelf obj = new Bookshelf();
        // obj.Accept();
        // obj.Display();

        //furniture = new Chair();

        // Chair chair = new Chair();
        // chair.Accept();
        // chair.Display();

        UnitConvertor conv = new UnitConvertor();
        double result = conv.Convert(300.00, "meters", "kilometers");

        Console.WriteLine(result);



    }

    public void Add(params int[] arr) //Parameter array Paramarray
    {
        int sum=0;
        for(int i = 0; i < arr.Length; i++)
        {
           sum+=arr[i]; 
        }
        Console.WriteLine($"Sum is {sum}");
    }

}