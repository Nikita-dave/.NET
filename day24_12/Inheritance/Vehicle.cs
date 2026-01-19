using System;

class Vehicle
{
    protected double distance=0.0;
    protected double hour=0.0;
    protected double fuel=0.0;

    public Vehicle(double distance,double hour,double fuel)
    {
        this.distance=distance;
        this.hour=hour;
        this.fuel=fuel;
    }

    public void Average()
    {
        double average=0.0;
        average=distance/fuel;
        Console.WriteLine("Vehicle Average is {0:0.00}",average);
    }

    public virtual void Speed()
    {
        double speed=0.0;
        speed=distance/hour;
        System.Console.WriteLine("Speed of the vehicle is {0:0.00}/kmph",speed);
    }
}