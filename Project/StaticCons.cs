using System;

class StaticCons
{
    //instance variable
    public int var=0;//Instance Variable

    public static int var1=5;//Static Variable

    public void Count()//Instance Method
    {
        var++;
        var1++;
    }

    public int DisplayInstance()
    {
        return var;
    }

    public static int Display() //Static Method
    {
        return var1;
    }
}