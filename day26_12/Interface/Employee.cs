using System;
using System.Runtime.Intrinsics.Arm;

public class Employee
{
    protected int Eid, Eage;
    protected string Ename, Eaddress;
    protected float Salary;
    public virtual void GetEmployeeData()
    {
        System.Console.WriteLine("ENTER EMPLOYEE DETAILS:");
        System.Console.WriteLine("Enter the id");
        Eid = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the name");
        Ename = Console.ReadLine();
        System.Console.WriteLine("Enter the address");
        Eaddress = Console.ReadLine();
        System.Console.WriteLine("Enter the age");
        Eage = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Salary");
        Salary= float.Parse(Console.ReadLine());
    }

    public virtual void DisplayEmployeeData()
    {
        System.Console.WriteLine("\nEmployee Details are: ");
        System.Console.WriteLine("Employee Id is: "+Eid);
        System.Console.WriteLine("Employee name is: "+Ename);
        System.Console.WriteLine("Employee address is: "+Eaddress);
        System.Console.WriteLine("Employee age is: "+Eage);
    }

    public virtual void CalculateSalary()
    {
        System.Console.WriteLine("Employee salary is: "+Salary);
    }
}