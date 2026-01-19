using System;
class AddGenericClass<T> //generic class
{
    T n1;
    T n2;
    T result;
    //default generic constructor
    public AddGenericClass()
    {
        
    }
    public AddGenericClass(T m, T n) //generic constructor
    {
        this.n1=m;
        this.n2=n;
    }

    public T MyProperty { get; set; } //generic property
    public T AddAllType(T num1, T num2)//generic method
    {
        dynamic x=num1;
        dynamic y = num2;
        result = x+y;
        return result;

    }
}
