using System;
class Car: Vehicle//Create a child class car from base class vehicle
{
    //call base class constructor in derive class
    public Car(double distance,double hour,double fuel) : base(distance, hour, fuel)
    {
        
    }

    public new void Average()
    {
        double average=0.0;
        average=distance/fuel;
        Console.WriteLine("Average of car is {0:0.00}",average);
    }

    public override void Speed()
    {
        double speed=0.0;
        speed=distance/hour;
        System.Console.WriteLine("Speed of the car is {0:0.00}/kmph",speed);
    }
}