using System;

public class Animal
{
    public virtual void MakeSound()
    {
        System.Console.WriteLine("Some generic animal Sound");
    }
}

public class Dog: Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Bark");
    }
}

public class Cat: Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Meow");
    }
}