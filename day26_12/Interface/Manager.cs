using System;

public sealed class Manager: Employee
{
    double Bonus, CA;
    public override void GetEmployeeData()
    {
        System.Console.WriteLine("Enter Manager details: ");
        System.Console.WriteLine("Enter the id");
        Eid = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the name");
        Ename = Console.ReadLine();
        System.Console.WriteLine("Enter the Bonus");
        Bonus = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the CA");
        CA = double.Parse(Console.ReadLine());
    }

    public override void DisplayEmployeeData()
    {
        System.Console.WriteLine("Manager Details are: ");
        System.Console.WriteLine("Manager Id is: "+Eid);
        System.Console.WriteLine("Manager name is: "+Ename);
        System.Console.WriteLine("Manager bonus is: "+Bonus);
        System.Console.WriteLine("Manager CA is: "+CA);
    }

    public override void CalculateSalary()
    {
        System.Console.WriteLine("Manager salary is: "+ Salary);
    }
}