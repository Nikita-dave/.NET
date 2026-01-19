using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousExtensionDemo
{
    public delegate void Print(int val, string str);
    public delegate void Print1(int val);
    public delegate int AddDel(int num1, int num2);
    delegate bool IsTeenAger(Student stud);

    class Program
    {

        public static void PrintHelperMethod(Print1 printDel, int val)
        {
            val += 10;
            printDel(val);
        }
        public static void Main(string[] args)
        {
            Student student = new Student
            {
                    Id = 101,
                    Name = "Test",
                    Age = 18
            };

            IsTeenAger isteenager = delegate (Student s) //Anonymous Method
            {
                return s.Age > 12 && s.Age < 20;
            };
            //Lambda Expression
            IsTeenAger isteenager1 = (s) => { return s.Age > 12 && s.Age < 20; };
            IsTeenAger isteenager2 = s => s.Age > 12 && s.Age < 20;
            Console.WriteLine(isteenager1(student));

            isteenager(student);

            //AddDel addNum = delegate (int num1, int num2)
            //{
            //    return num1 + num2;
            //};

            //Lambda Expression
            AddDel addDel = (int num1, int num2) => { return num1 + num2; };
            int sum = addDel(50, 60);

            //int sum = addNum(30, 20);
            Console.WriteLine($"Sum is: {sum}");

            //PrintHelperMethod(30, 20);
            //2
            //Passing Anonymous with 2 parameter
            PrintHelperMethod(delegate (int val)
            {
                Console.WriteLine("Anonymous method: {0}",val);
            },100);
            //1
            Print print = delegate (int val, string str)
            {
                Console.WriteLine($"Hello World {val} {str}");
            };

            print(100, "Welcome");

            var ManagerInfo = new //Anonymous Type
            {
                id = 1001,
                Name = "Rajesh Patel"
            };
            Console.WriteLine($"Manager id is {ManagerInfo.id}");
            Console.WriteLine($"Manager name is {ManagerInfo.Name}");
            //ManagerInfo.id = 1002; //error
            //ManagerInfo.Name = "Rakesh Kumar"; //error

            //MyMethod(ManagerInfo);
        }
        public static void MyMethod(dynamic dy)
        {
            Console.WriteLine(dy);
            Console.WriteLine(dy);
        }
    }
}
