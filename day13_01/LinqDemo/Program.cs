using System;
using System.Data;
using System.Linq;

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        //Data Source
        //create an instance of Employees DataTable
        Employees employees = new Employees();
        //Add rows to DataTable
        employees.Rows.Add(1, "John", 25, "IT", 50000);
        employees.Rows.Add(2, "Moin", 30, "HR", 60000);
        employees.Rows.Add(3, "Bill", 28, "Finance", 55000);
        employees.Rows.Add(4, "Ram", 35, "IT", 70000);
        //Write Linq Query
        //using LINQ to query DataTable
        var query = from employee in employees.AsEnumerable()
                    where employee.Field<string>("Department") == "IT"
                    orderby employee.Field<int>("Salary") descending
                    select new
                    {
                        Id = employee.Field<int>("Id"),
                        Name = employee.Field<string>("Name"),
                        Age = employee.Field<int>("Age"),
                        Department = employee.Field<string>("Department"),
                        Salary = employee.Field<int>("Salary")
                    };
        //Execute query
        foreach (var item in query)
        {
            System.Console.WriteLine("Id: {0}, Name: {1}, Age: {2}, Department: {3}, Salary: {4}",
                item.Id, item.Name, item.Age, item.Department, item.Salary);
        }


        // //Student collection
        // IList<Student> studentList = new List<Student>()
        // {
        //     new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
        //     new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        //     new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        //     new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        //     new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        // };
        // //Write the query
        // // IEnumerable<Student> teenAgerStudents =
        // //Query Syntax
        // var students = from s in studentList
        //     where s.Age > 12 && s.Age < 20
        //     select s;

        // //Method Syntax
        // var studentss = studentList.Where(s=>s.Age>12 && s.Age<20);
        // //Execute the query
        // foreach (Student s in students)
        // {
        //     System.Console.WriteLine($"Id: {s.StudentID}, Name: {s.StudentName}, Age: {s.Age}");
        // }

        // //string collection DataSource
        // IList<string> stringList = new List<string>()
        // {
        //     "C# Tutorials",
        //     "VB.NET Tutorials",
        //     "C++ Learning",
        //     "Java",
        //     "MVC Tutorials",
        //     "Python",
        // };
        // //Write Query
        // //LINQ Query syntax
        // var result = from s in stringList
        //             where s.Contains("Tutorials")
        //             select s;

        // //Execute the query
        // foreach (string str in result)
        // {
        //     System.Console.WriteLine(str);
        // }


        // //Data Source
        // string[] names = {"Bill", "John", "Steve", "James", "Mary"};
        // //Write the query
        // // IEnumerable<string> names =
        // //Query Syntax
        // // var name = from  s in names
        // //             where s.Contains('a')
        // //             select s;
        
        // //Method Syntax
        // var name = names.Where(s=>s.Contains('a'));
        // //Execute the query
        // foreach (string s in name)
        // {
        //     System.Console.WriteLine(s);
        // } 
    }
}