// using System;
// using System.Collections;

// public class Program {
//     public static void Main(string[] args)
//     {
//         ArrayList studentNames = new ArrayList();
//         while (true)
//         {
//             string input = Console.ReadLine();

//             if(input == null)
//             {
//                 continue;
//             }
//             if(input.ToLower()== "stop")
//             {
//                 break;
//             }
//             if (!IsValidName(input))
//             {
//                 continue;
//             }
//             if(IsNameInCollection(studentNames, input))
//             {
//                 System.Console.WriteLine(input+" is already in the collection");
//             }
//             else
//             {
//                 studentNames.Add(input);
//                 System.Console.WriteLine(input+" added to the collection");
//             }

//         }
//         DisplayStudentNames(studentNames);

//     }
//     private static bool IsValidName(string name)
//     {
//         if(name =="")
//         {
//             return false;
//         }
//         return true;
//     }
//     private static bool IsNameInCollection(ArrayList studentNames, string name)
//     {
//         foreach (string i in studentNames)
//         {
//             if(i.ToString().ToLower() == name.ToLower())
//             {
//                 return true;
//             }
//         }
//         return false; 
//     }
//     private static void DisplayStudentNames(ArrayList studentNames)
//     {
//         System.Console.WriteLine("Unique student names entered:");
//         foreach (string name in studentNames)
//         {
//             System.Console.WriteLine(name);
//         }
//     }
// }

// using System;
// using System.Collections;

// public class Program
// {
//     private static ArrayList numbers = new ArrayList();
//     public static void Main(string[] args)
//     {        
//         while (true)
//         {
//             string operation = Console.ReadLine();
//             if(operation == "add")
//             {
//                 AddNumber();
//             }
//             else if(operation == "remove")
//             {
//                 RemoveNumber();
//             }else if(operation == "display")
//             {
//                 DisplayNumbers();
//             }else if(operation == "exit")
//             {
//                 break;
//             }
//             else
//             {
//                 System.Console.WriteLine("Invalid command.");
//             }
//         }
//     }
//     private static void AddNumber()
//     {
//         try
//         {
//             int number = Convert.ToInt32(Console.ReadLine());
//             numbers.Add(number);
//             System.Console.WriteLine($"{number} added to the number list.");
//         }
//         catch
//         {
//             System.Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }
//     private static void RemoveNumber()
//     {
//         try
//         {
//             int number = Convert.ToInt32(Console.ReadLine());
//             if (numbers.Contains(number))
//             {                
//                 numbers.Remove(number);
//                 System.Console.WriteLine($"{number} removed from the number list.");
//             }
//             else
//             {
//                 System.Console.WriteLine($"{number} not found in the number list.");
//             }
//         }
//         catch
//         {
//             System.Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }
//     private static void DisplayNumbers()
//     {
//         System.Console.WriteLine("Current numbers in the list:");
//         foreach (object num in numbers)
//         {
//             System.Console.WriteLine(num);
//         }
//     }
// }

// using System;
// using System.Collections;

// class Album
// {
//     public string Title { get; set; }
//     public string Artist { get; set; }
// }
// class Program
// {
    
//     public static void Main(string[] args)
//     {
//         ArrayList albums = new ArrayList();
//         while (true)
//         {
//             string title = Console.ReadLine();
//             if(title == "quit")
//             {
//                 break;
//             }
//             string artist = Console.ReadLine();

//             if(IsValidInput(title) && IsValidInput(artist))
//             {
//                 Album album = new Album();
//                 album.Title = title;
//                 album.Artist = artist;

//                 albums.Add(album);

//             }
//         }
//         DisplayAlbums(albums);
//     }
//     private static bool IsValidInput(string input)
//     {
//         if(input == null)
//         {
//             return false;
//         }
//         if (input == "" || input == " ")
//         {
//             return false;
//         }
//         return true;
//     }

//     private static void DisplayAlbums(ArrayList albums)
//     {
//         foreach (Album al in albums)
//         {
//             System.Console.WriteLine($"Title: {al.Title}, Artist: {al.Artist}");
//         }
//     }
// }

// using System;
// using System.Collections;
// using System.Collections.Generic;
// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public string Grade { get; set; }
// }
// public class StudentManager
// {
//     static Dictionary<int, Student> Students = new Dictionary<int, Student>();
//     public static void AddStudent(Student student)
//     {
//         // Students.Add(student.Id, student);

//         // Overwrites if ID already exists
//         Students[student.Id] = student;
//     }
//     public static void DisplayStudent()
//     {
//         System.Console.WriteLine("Student Information:");
//         foreach (KeyValuePair<int, Student> keyValuePair in Students)
//         {
//             System.Console.WriteLine($"ID: {keyValuePair.Value.Id}, Name: {keyValuePair.Value.Name}, Grade: {keyValuePair.Value.Grade}");
//         }
        
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         int count = Convert.ToInt32(Console.ReadLine());
//         for(int i=0;i<count;i++)
//         {
//             int id = Convert.ToInt32(Console.ReadLine());
//             string name = Console.ReadLine();
//             string grade = Console.ReadLine();
//             Student student = new Student();
//             student.Id = id;
//             student.Name = name;
//             student.Grade = grade;
//           StudentManager.AddStudent(student);  
//         }
//         StudentManager.DisplayStudent();
//     }
// }

using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        LinkedList<string> studentList = new LinkedList<string>();
        while (true)
        {
            System.Console.WriteLine("LinkedList Operations:");
            System.Console.WriteLine("1. Add Student\n2. Display Students\n3. Update Student\n4. Delete Student by Name\n5. Clear List\n6. Exit");
            Console.Write("Enter your choice (1-6): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddStudents(studentList);
                    break;
                case 2:
                    DisplayStudents(studentList);
                    break;
                case 3:
                    UpdateStudents(studentList);
                    break;
                case 4:
                    DeleteByName(studentList);
                    break;
                case 5:
                    ClearList(studentList);
                    break;
                case 6:
                    System.Console.WriteLine("Exiting...");
                    return;
                default:
                    System.Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }

    public static void AddStudents(LinkedList<string> studentList)
    {
        System.Console.WriteLine("Enter student name to add: ");
        string name = Console.ReadLine();
        studentList.AddLast(name);
        System.Console.WriteLine($"{name} added to the list.");
    }

    public static void DisplayStudents(LinkedList<string> studentList)
    {
        System.Console.WriteLine("Students in the list:");
        foreach(var student in studentList)
        {
            System.Console.WriteLine(student);
        }
    }

    public static void UpdateStudents(LinkedList<string> studentList)
    {
        
    }

    public static void DeleteByName(LinkedList<string> studentList)
    {
        
    }

    public static void ClearList(LinkedList<string> studentList)
    {
        
    }
}