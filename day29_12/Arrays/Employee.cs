using System;

class Employee: IComparable<Employee>
{
    public int Id{ get; set; }
    public string Name { get; set; }

    public int CompareTo(Employee other)
    {
        return this.Id.CompareTo(other.Id);//ascending
    }

    public override string ToString()
    {
        return $"Employee Id is {Id} "+
                $"Employee name is {Name}";
    }
}