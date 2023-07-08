namespace MyFirstApplication;

internal struct Employee
{
    public int _id;
    public string _name;

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


