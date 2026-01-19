using System.ComponentModel.DataAnnotations;

[DebugInfo(45, "Zara Ali","22/8/2012", Message ="Return type mismatch")]
[DebugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variabe")]

class Rectangle
{
    protected double length;
    protected double width;
    public Rectangle(double l, double w)
    {
        length =l;
        width = w;
    }
    [DebugInfo(55, "Zara Ali","19/10/2012", Message ="Return type mismatch")]

    public double GetArea()
    {
        return length * width;
    }
    [DebugInfo(56, "Nuha Ali", "19/10/2012")]

    public void Display()
    {
        System.Console.WriteLine("Length: {0}",length);
        System.Console.WriteLine("Width: {0}", width);
        System.Console.WriteLine("Area: {0}",GetArea());
    }
}