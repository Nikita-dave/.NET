using System;

class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public float Salary { get; set; }

    public Employee()
    {
        EmployeeId=0;
        Name= string.Empty;
        Salary=0.0f;
    }

    public Employee(int Empid,string Name,float Salary)
    {
        this.EmployeeId=Empid;
        this.Name= Name;
        this.Salary=Salary;
    }

    //to override write override then select to string press enter
    //overriding to string method
    public override string ToString()
    {
        return $"Employee Details are\n Employee Id is {EmployeeId}\n Employee Name is {Name} \n Employee Salary is {Salary}";
    }
}
