using System;
[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]
public class DebugInfo : System.Attribute
{
    private  int bugNo;
    private string developers;
    private string lastReview;
    public string message;
    public DebugInfo(int bg, string dev, string d)
    {
        this.bugNo = bg;
        this.developers = dev;
        this.lastReview = d;
    }

    public int BugNo
    {
        get
        {
            return bugNo;
        }
    }

    public string Developers
    {
        get
        {
            return developers;
        }
    }
    public string LastReview
    {
        get
        {
            return lastReview;
        }
    }
    public string Message{
        get
        {
            return message;
        }
        set
        {
            message = value;
        }
    }
}
