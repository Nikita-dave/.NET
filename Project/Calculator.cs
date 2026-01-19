using System;

class Calculator
{
    // private  int n1;
    // public int n2
    // {
    //     get
    //     {
    //         return n1;
    //     }
    //     set
    //     {
    //         n1 = value;
    //     }
    // }

    //for auto implement write prop and then press tab
    public int Number1 { get; set; }
    public int Number2{ get; set; }
    public int Result { get; set; }

    //for constructor write ctr then press tab
    public Calculator()//default constructor
    {
        Number1=0;
        Number2=0;
        Result=0;
    }

    public Calculator(int Number1,int Number2) //parameterised constructor
    {
        this.Number1 = Number1;
        this.Number2= Number2;
        Result = 0;
    }

    //Method with parameter with return type
    public int Add(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
        Result = number1+number2;
        return Result;
    }
    
    //Method without parameter with return type

    public int Subtract()
    {
        Number1 = 30;
        Number2 = 20;
        Result = Number1-Number2;

        return Result;
    }

    //Method with parameter without return type

    public void Multiply(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
        Result = Number1*Number2;
        Console.WriteLine($"Multiplication of the two number {Number1} and {Number2} is {Result}");
    }

    //Method without parameter without return type

    public void Divide()
    {
        Result = Number1/Number2;
        Console.WriteLine($"Division of the two Numbers {Number1} and {Number2} is {Result}");
    }

    // public void Add()
    // {
        
    // }

    //inparameter pass by value

    public void Swap(int num1, int num2)
    {
        int n1=num2;
        int n2=num2;
        int temp=0;

        // Console.WriteLine($"Before Swaping {num1} and {num2}");
        temp=n1;
        n1=n2;
        n2=temp;
        // Console.WriteLine($"After Swaping {num1} and {num2}");
    }

    //inout pass by reference

        public void Swapref(ref int num1,ref int num2)
    {
        // int n1=num2;
        // int n2=num2;
        int temp=0;

        // Console.WriteLine($"Before Swaping {num1} and {num2}");
        temp=num1;
        num1=num2;
        num2=temp;
        // Console.WriteLine($"After Swaping {num1} and {num2}");
    }

    public void Addition(int n1,int n2,out int res,out int n3, out int n4)
    {
        n3=n1;
        n4=n2;
        res = n1+n2;
    }
}