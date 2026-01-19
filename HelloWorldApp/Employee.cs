namespace HelloWorldApp{
    class Employee
    {
        int Id;
        string Name;
        string Department;
        float Salary;
        char Gender;
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Employees Details");
            Console.WriteLine("Enter Employee Id");
            Id=Convert.ToInt32(Console.ReadLine());
            // Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            Department=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            Salary=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Employee Gender");
            Gender= Convert.ToChar(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employees Details are:");
            Console.WriteLine($"Employee Id is {Id}");
            Console.WriteLine($"Employee Name is {Name}");
            Console.WriteLine($"Employee Department is {Department}");
            Console.WriteLine($"Employee Salary is {Salary}");
            Console.WriteLine($"Employee Gender is {Gender}");
        }
    }
}