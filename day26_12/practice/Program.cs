using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n <=0)
        {
            System.Console.WriteLine("Please enter a valid positive integer");
        }
        string[] s = new string[n];
        for(int i = 0; i < n; i++)
        {
            s[i] = Console.ReadLine();
        }

        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();
        Console.WriteLine("Sound of the animals in the array");
        for(int i = 0; i < n; i++)
        {
            if (s[i] == "animal")
            {
                animal.MakeSound();
            }else if (s[i] == "dog")
            {
                dog.MakeSound();
            }
            else if(s[i]=="cat")
            {
                cat.MakeSound();
            }
            else
            {
                System.Console.WriteLine("Some other sound");
            }
        }
        
    }
}