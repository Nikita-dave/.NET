using System;
class AddTwoNumbers
{
    public delegate void dg_OddNumber(); //Declared Delegate
    public event dg_OddNumber ev_OddNumber; //Declared Events
    public void Add()
    {
        int result;
        result = 5+4;
        System.Console.WriteLine(result.ToString());
        //Check if result is odd number then raise event
        if ((result % 2 != 0) && (ev_OddNumber != null))
        {
            ev_OddNumber(); //Raised Event
        }
    }
}