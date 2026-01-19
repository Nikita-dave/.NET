using System;
using HelloWorldApp;
class HelloWorld
{
    int a, b;
    int result;

    public static void Main(string[] arg)
    {
        //Console.WriteLine("Hello World");

        //Employee employee = new Employee();
        //employee.AcceptDetails();
        //employee.DisplayDetails();

        // Calculator calc = new Calculator();
        // calc.Add();
        // calc.Subtract();
        // calc.Multiply();
        // calc.Division();
        // calc.Remainder();

        // 1)Sample C# program to print a welcome message
        // Console.WriteLine("Welcome to Hello World App");

        // 2)Write C# program to read a number user and display it */
        // int a = 0;
        // Console.WriteLine("Enter the Number : ");
        // a = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Number is {a}");
        // Console.ReadLine(); 

        // 3)Write C# program to read a floating point number from user 
        // float a = 0.0f;
        // Console.WriteLine("Enter the Number : ");
        // a = Convert.ToSingle(Console.ReadLine());
        // Console.WriteLine($"Number is {a}");
        // Console.ReadLine(); 

        // 4)Write C# program to read a string from user and display it on the screen         
        // string s = string.Empty;
        // Console.WriteLine("Enter the String: ");
        // s = Console.ReadLine();
        // Console.WriteLine($"String is {s}");

        // 5)Write C# program to perform all arithmetic operations*/

        // 6)Write C# program to find the area of circle */
        // int r;
        // float pie = 3.14f;
        // Console.WriteLine("Enter the Radius of the Circle: ");
        // r = Convert.ToInt32(Console.ReadLine());
        // float result = pie*r*r;
        // Console.WriteLine($"The area of the circle with radius {r} is {result} ");

        // float r= 0;
        // float area = 0.0f;
        // Console.WriteLine("Enter the Radius of the Circle: ");
        // r = Convert.ToInt32(Console.ReadLine());
        // area = (22/7)*r*r;
        // Console.WriteLine($"The area of the circle with radius {r} is {area} ");

        // 7) program to find whether the given number is Even or Odd */
        // int a =0;
        // Console.WriteLine("Enter the Number: ");
        // a = Convert.ToInt32(Console.ReadLine());
        // if(a%2== 0)
        // {
        //     Console.WriteLine($"The Number {a} is Even");
        // }
        // else
        // {
        //     Console.WriteLine($"The Number {a} is Odd");
        // }

        // 8)program to find the greatest of 2 numbers */
        // int a=0, b=0;
        // Console.WriteLine("Enter the Numbers: ");
        // Console.WriteLine("a: ");
        // a = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("b: ");
        // b = Convert.ToInt32(Console.ReadLine());
        // if(a>b)
        // {
        //     Console.WriteLine($"{a} is the greater than {b}");
        // }
        // else
        // {
        //     Console.WriteLine($"{b} is the greater than {a}");
        // }

        // 9) program to find whether a given number is positive ,negative or zero*/
        // float a =0.0f;
        // Console.WriteLine("Enter the Number: ");
        // a = Convert.ToSingle(Console.ReadLine());
        // if (a < 0)
        // {
        //     Console.WriteLine($"The Number {a} is negative");
        // }
        // else if (a == 0)
        // {
        //     Console.WriteLine($"The Number {a} is equal to 0");
        // }
        // else
        // {
        //     Console.WriteLine($"The Number {a} is positive");
        // }

        // 10 program to find the greatest of three numbers using nested if*/
        // int a, b, c;
        // Console.WriteLine("Enter the Numbers: ");
        // Console.WriteLine("a: ");
        // a = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("b: ");
        // b = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("c: ");
        // c = Convert.ToInt32(Console.ReadLine());
        // if(a>b)
        // {
        //     Console.WriteLine($"{a} is the greatest");
        // }
        // else if(b>a && b > c)
        // {
        //     Console.WriteLine($"{b} is the greatest");
        // }
        // else
        // {
        //     Console.WriteLine($"{c} is the greatest");
        // }

        // int a, b, c;
        // Console.WriteLine("Enter the Numbers: ");
        // Console.WriteLine("a: ");
        // a = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("b: ");
        // b = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("c: ");
        // c = Convert.ToInt32(Console.ReadLine());
        // if(a>b)
        // {
        //     if (a > c)
        //     {
        //         Console.WriteLine($"{a} is the greatest");
        //     }
        // }
        // else if(b>a)
        // {
        //     if(b > c)
        //     {    
        //         Console.WriteLine($"{b} is the greatest");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine($"{c} is the greatest");
        // }

        // Character is Vowel Using Switch Case

        // char ch;
        // Console.WriteLine();
        // ch= Convert.ToChar(Console.ReadLine());

        // switch (ch)
        // {
        //     case 'a':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     case 'e':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     case 'i':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     case 'o':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     case 'u':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     case 'A':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     case 'E':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     case 'I':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     case 'O':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     case 'U':
        //         Console.WriteLine($"The Character {ch} is Vowel");
        //         break;
        //     default:
        //         Console.WriteLine($"The Character {ch} is not Vowel");
        //         break;
        // }

        // Covert String to Uppercase and find the length of the string

        // string str = string.Empty;
        // int length=0;
        // str = Console.ReadLine();

        // length = str.Length;
        // str = str.ToUpper();
        // Console.WriteLine($"Original String Length: {length}");
        // Console.WriteLine($"Uppercase String: {str}");


        // Swap two numbers without using temp or any additional variable
        // int a = 0;
        // a= Convert.ToInt32(Console.ReadLine());
        // int b=0;
        // b = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Before swap: a = {a}, b = {b}");

        // a = a+b;
        // b = a-b;
        // a = a-b;
        // Console.WriteLine($"After swap: a = {a}, b = {b}");


        // calculator using switch case
        // int a =0, b=0;
        // char ch;
        // int result =0;
        // a = Convert.ToInt32(Console.ReadLine());
        // b = Convert.ToInt32(Console.ReadLine());
        // ch = Convert.ToChar(Console.ReadLine());

        // switch (ch)
        // {
        //     case '+':
        //         result = a+b;
        //         Console.WriteLine($"The sum of {a} and {b} is {result}");
        //         break;
        //     case '-':
        //         result = a-b;
        //         Console.WriteLine($"The difference of {a} and {b} is {result}");
        //         break;
        //     case '*':
        //         result = a*b;
        //         Console.WriteLine($"The multiplication of {a} and {b} is {result}");
        //         break;
        //     case '/':
        //         result = a/b;
        //         Console.WriteLine($"The division of {a} and {b} is {result} ");
        //         break;
        //     default:
        //         Console.WriteLine("Enter the correct Operator");
        //         break;
        // }

        // HelloWorld hello = new HelloWorld();
        // int choice =0;
        // Console.WriteLine("1 for Addition");
        // Console.WriteLine("2 for Subtraction");
        // Console.WriteLine("3 for Multiplication");
        // Console.WriteLine("4 for Division");
        // Console.WriteLine("5 for Remainder");
        // Console.WriteLine("6 for Exit");
        // Console.WriteLine("Select option from the following list");
        // choice =Convert.ToInt32(Console.ReadLine());

        // switch (choice)
        // {
        //     case 1: hello.Add();
        //     break;
        //     case 2: hello.Subtract();
        //     break;
        //     case 3: hello.Multiply();
        //     break;
        //     case 4: hello.Division();
        //     break;
        //     case 5: hello.Remainder();
        //     break;
        //     case 6: return;

        //     default: Console.WriteLine("Invalid option Enter option between 1 to 5");
        //     break;
        // }

        //write a program to print number between 1 to 10
        // int i=1;
        // while (i <= 10)
        // {
        //     Console.WriteLine($"The Numbers are {i}");
        //     i++;
        // }

        // int i=10;
        // while (i>0)
        // {
        //     Console.WriteLine($"The Numbers are {i}");
        //     i--;
        // }

        //do while
        // int i=0;
        // do
        // {
        //     Console.WriteLine($"Number is {i}");
        //     i++;
        // }
        // while(i<=10);

        // int i=10;
        // do
        // {
        //     Console.WriteLine($"Reverse Number is {i}");
        //     i--;
        // }
        // while(i>0);

        //for loop
        // for(int i=0; i <= 10; i++)
        // {
        //     Console.WriteLine($"Number is {i}");
        // }

        // for(int i = 10; i > 0; i--)
        // {
        //     Console.WriteLine($"Reverse Number is {i}");
        // }

        // int[] arr =[10,20,30,40,50,60,70,80,90,100];

        // int i=0;
        // while (i < arr.Length)
        // {
        //     Console.WriteLine($"arr index at {i} is {arr[i]}");
        //     i++;
        // }

        // for(int i = 0; i < arr.Length; i++)
        // {
        //     Console.WriteLine($"arr index at {i} is {arr[i]}");
        // }

        // foreach(int i in arr)
        // {
        //     Console.WriteLine(i);
        // }

        //17)Write C#  program to print numbers from 1 to n(user input) using while loop
        // int n=0;
        // Console.WriteLine("Enter the user input");
        // n = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine($"The number upto {n} are");
        // int i=1;
        // while (i <= n)
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }


        // 18)Write C#  program to print even numbers from 1 to n(user input)
        // int n=0;
        // Console.WriteLine("Enter the user input");
        // n = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine($"The even numbers upto {n} are");
        // int i=0;
        // while (i <= n)
        // {
        //     Console.WriteLine(i);
        //     i = i+2;
        // } 

        // 19)Write C#  program to find the sum  of numbers from 1 to n(user input) using while loop

        // int n=0;
        // Console.WriteLine("Enter the user input");
        // n = Convert.ToInt32(Console.ReadLine());

        // int sum=0;
        // int i=0;
        // while (i <= n)
        // {
        //     sum += i;
        //     i++;
        // }

        // Console.WriteLine($"The sum of numbers upto {n} is: {sum}");


        // 20)Write C#  program to print multiplication table of given number */
        // int n=0;
        // Console.WriteLine("Enter the user input");
        // n = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Multiplication Table: ");

        // for(int i = 1; i <= 10; i++)
        // {
        //     int result =  i*n;
        //     Console.WriteLine($"{i} * {n} = {result}");
        // }

        // 21) Write C#  program to calculate the power of a given number
        // int n=0;
        // Console.WriteLine("Enter The Number: ");
        // n = Convert.ToInt32(Console.ReadLine());
        // int x=0;
        // x = Convert.ToInt32(Console.ReadLine());
        // int pow=1;
        // for(int i = 1; i <= x; i++)
        // {
        //     pow *= n;
        // }
        // Console.WriteLine($"Power of the given number is {pow}");

        // 22)Write C#  program to generate fibbonacci series(0 1 1 2 3 5 8 13 21 34 55...) upto n(user input)*/
        // int n =0;
        // Console.WriteLine("Enter the Number: ");
        // n = Convert.ToInt32(Console.ReadLine());
        // int f1=0, f2=1, next;
        // for(int i = 0; i <= n; i++)
        // {
        //     Console.Write(f1+" ");
        //     next = f1+f2;
        //     f1 =f2;
        //     f2 = next;
        // }


        // 23)Write C#  program to find whether the given number is Armstrong or not
        // int n;
        // Console.WriteLine("Enter the number: ");
        // n = Convert.ToInt32(Console.ReadLine());
        // int original = n;
        // int sum = 0;
        // int digits = n.ToString().Length;  

        // while (n > 0)
        // {
        //     int x = n % 10;
        //     sum += (int)Math.Pow(x, digits);  
        //     n /= 10;
        // }

        // if (sum == original)
        // {
        //     Console.WriteLine($"{original} is an Armstrong number.");
        // }
        // else
        // {
        //     Console.WriteLine($"{original} is not an Armstrong number.");
        // }

        // 24) Program to print Armstrong numbers from n1 to n2
        // Console.WriteLine("Enter n1: ");
        // int n1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter n2: ");
        // int n2 = Convert.ToInt32(Console.ReadLine());

        // for (int i = n1; i <= n2; i++)
        // {
        //     int temp = i;
        //     int sum2 = 0;
        //     int digits2 = i.ToString().Length;

        //     while (temp > 0)
        //     {
        //         int digit = temp % 10;
        //         sum2 += (int)Math.Pow(digit, digits2);
        //         temp /= 10;
        //     }

        //     if (sum2 == i)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }


        // 25) program to check whether the number is prime or not
        // Console.WriteLine("Enter a number to check if prime: ");
        // int num = Convert.ToInt32(Console.ReadLine());

        // if (num <= 1)
        // {
        //     Console.WriteLine($"{num} is not a prime number.");
        // }
        // else
        // {
        //     bool isPrime = true;
        //     for (int i = 2; i <= Math.Sqrt(num); i++)
        //     {
        //         if (num % i == 0)
        //         {
        //             isPrime = false;
        //             break;
        //         }
        //     }
        //     if (isPrime)
        //     {
        //         Console.WriteLine($"{num} is a prime number.");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{num} is not a prime number.");
        //     }
        // }


        // 29)
        // C# Program to Print Odd Numbers in a Given Range
        // This is a C# Program to generate odd numbers within a range.

        // Problem Description
        // This C# Program Generates Odd Numbers within a Range.

        // Problem Solution
        // Here Enumerable.Range generates a collection of odd numbers of a specified range.
        // Runtime Test Cases

        // 21
        // 23
        // 25
        // 27
        // 29
        // 31
        // 33
        // 35
        // 37
        // 39

        // int n1, n2;
        // Console.WriteLine("Enter the Range: ");
        // n1= Convert.ToInt32(Console.ReadLine());
        // n2 = Convert.ToInt32(Console.ReadLine());
        // for(int i = n1; i <= n2; i++)
        // {
        //     if (i % 2 != 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        //         C# Program to Find the Sum of All the Multiples of 3 and 5
        // This is a C# Program to print the sum of all the multiples of 3 and 5.

        // Problem Description
        // This C# Program Prints the Sum of all the Multiples of 3 and 5.

        // Problem Solution
        // Here the multiples of 3 and 5 are found and the sum of all the multiples are calculated and are displayed.

        // Runtime Test Cases

        // 3  5  6  9  10  12  15  18  20  21  24  25  27  30  33  35  36  
        // 39  40  42  45  48 50  51  54  55  57  60  63  65  66  69  70  72  
        // 75  78  80  81  84  85  87  90  93  95  96  99
        // The Sum of all the Multiples of 3 or 5 Below 100 : 2318

        // int sum=0;
        // for(int i = 1; i < 100; i++)
        // {
        //     if(i%3==0 || i % 5 == 0)
        //     {
        //         Console.Write(i+" ");
        //         sum+=i;
        //     }
        // }
        // Console.WriteLine();
        // Console.WriteLine($"The Sum of all the multiples of 3 or 5 below 100: {sum}");

        // 26)program to print numbers from 1 to 5(R to L)

        //      1
        //     12
        //    123
        //   1234
        //  12345

        // int n=1;
        // int row;
        // Console.WriteLine("Enter Number of rows: ");
        // row = Convert.ToInt32(Console.ReadLine());
        // for(int i = 0; i <row; i++)
        // {
        //     for(int j = 0; j < 2*(row-i)-1; j++)
        //     {
        //         Console.Write(" ");
        //     }

        //     for(int k = 0; k <= i; k++)
        //     {
        //         Console.Write($"{k+1} ");
        //     }
        //     Console.WriteLine();
        // }

        //         27)
        // program to print the output as following 

        //      *
        //     **
        //    ***
        //   ****
        //  *****

        // int row;
        // Console.WriteLine("Enter Number of rows: ");
        // row = Convert.ToInt32(Console.ReadLine());
        // for(int i = 0; i < row; i++)
        // {
        //     for(int j = 0; j < 2 * (row - i) - 1; j++)
        //     {
        //         Console.Write(" ");
        //     }
        //     for(int k = 0; k <= i; k++)
        //     {
        //         Console.Write("* ");
        //     }
        //     Console.WriteLine();
        // }

        //         28)
        // program to read student details (no, name,marks)using do 
        // while loop by accepting details till user enter y as an 
        // input */

        // char ch = Convert.ToChar(Console.ReadLine());
        
        // do
        // {
            
        // }
        // while(ch=='y');

        // int year = Convert.ToInt32(Console.ReadLine());
        // if((year%4 == 0 && year%100 != 0) || year%400 == 0)
        // {
        //     Console.WriteLine($"{year} is a leap year");
        // }
        // else
        // {
        //     Console.WriteLine($"{year} is not a leap year");
        // }
        
        // float celsius = 0.0f;
        // celsius = Convert.ToSingle(Console.ReadLine());
        // float fahrenheit = (celsius * 9/5) +32;

        // Console.WriteLine($"Temperature in Celsius: {celsius}");
        // Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");

        // int n = Convert.ToInt32(Console.ReadLine());
        // if (n >= 90)
        // {
        //     Console.WriteLine("Grade A");
        // }else if (n >= 80 && n<90)
        // {
        //     Console.WriteLine("Grade B");
        // }else if (n >= 70 && n < 80)
        // {
        //     Console.WriteLine("Grade C");            
        // }else if (n >= 60 && n < 70)
        // {
        //     Console.WriteLine("Grade D");
        // }else
        // {
        //     Console.WriteLine("Grade F");
        // }
        
         

        Console.ReadLine();

    }

    // public void Add()
    // {
    //     Console.WriteLine("Enter First Number");
    //     a = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Enter Second Number");
    //     b = Convert.ToInt32(Console.ReadLine());
    //     result = a+b;
    //     Console.WriteLine($"Sum of the two Number is {result}");
    // }
    // public void Subtract()
    // {
    //     Console.WriteLine("Enter First Number");
    //     a = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Enter Second Number");
    //     b = Convert.ToInt32(Console.ReadLine());
    //     result = a-b;
    //     Console.WriteLine($"Subtraction of the two Number is {result}");
    // }
    // public void Multiply()
    // {
    //     Console.WriteLine("Enter First Number");
    //     a = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Enter Second Number");
    //     b = Convert.ToInt32(Console.ReadLine());
    //     result = a*b;
    //     Console.WriteLine($"Multiplication of the two Number is {result}");
    // }
    // public void Division()
    // {
    //     Console.WriteLine("Enter First Number");
    //     a = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Enter Second Number");
    //     b = Convert.ToInt32(Console.ReadLine());
    //     result = a/b;
    //     Console.WriteLine($"Division of the two Number is {result}");
    // }

    // public void Remainder()
    // {
    //     Console.WriteLine("Enter First Number");
    //     a = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Enter Second Number");
    //     b = Convert.ToInt32(Console.ReadLine());
    //     result = a%b;
    //     Console.WriteLine($"Remainder of the Number is {result}");
    // }
}
