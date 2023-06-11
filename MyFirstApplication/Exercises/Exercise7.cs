

using DocumentFormat.OpenXml.Drawing.Charts;

namespace MyFirstApplication;

internal struct Employee
{
    private int _id;
    private string _name;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Employee(int id, string name)
    {
        _id = id;
        _name = name;
    }

    public override string ToString()
    {
        return _name;
    }

   
}
