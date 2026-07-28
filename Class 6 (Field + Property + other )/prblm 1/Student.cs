
using System.Net.WebSockets;

public class Student
{
    private string _name = string.Empty;
    private int _age;

    public string Name
    {
        get { return _name; }

        set
        {
            if ( value != null)
            {
                _name = value;
            }
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if(value > 0)
            {
                _age = value;
            }
        }
    }
}

