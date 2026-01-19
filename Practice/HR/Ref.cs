using System;

class Ref
{
    public void Swap(ref int s1, ref int s2)
    {
        int temp;
        temp = s1;
        s1 = s2;
        s2 = temp;
    }
}