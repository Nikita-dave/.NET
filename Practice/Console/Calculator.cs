using System;

class Calculator
{
    public void Addition(int n1, int n2, out int sum, out int n3, out int n4)
    {
        n3= n1;
        n4= n2;
        sum= n1 + n2;
    }
}