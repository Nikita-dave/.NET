using System;

class Billing
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public Billing()
    {
        Number1=0;
        Number2=0;
    }

    public Billing(int Number1, int Number2)
    {
        this.Number1=Number1;
        this.Number2=Number2;
    }
}

