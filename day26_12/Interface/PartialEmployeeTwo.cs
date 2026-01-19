using System;
namespace PartialDemo
{
    public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            System.Console.WriteLine(@"Full Name is : {0} {1}", _firstName, _lastName);
        }

        public void DisplayEmployeeDetails()
        {
            System.Console.WriteLine("Employee Details: ");
            System.Console.WriteLine("First Name: {0}",_firstName);
            System.Console.WriteLine("Last Name: {0}",_lastName);
            System.Console.WriteLine("Gender: {0}",_gender);
            System.Console.WriteLine("Salary: {0}",_salary);
        }

        public partial void PartialMethod()
        {
            Console.WriteLine("Partial PartialMethod Invoked");
        }
    }
}