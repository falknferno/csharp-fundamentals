

namespace MyFirstApplication;


/*
 Encapsulation is the process of wrapping data and the code
 into a single unit.
 */
internal class Lesson10
{
    private string _firstname;
    private string _address;
    protected int zipcode;

    public string Firstname
    {
        get { return _firstname; }
        set { _firstname = value; } //value is implict as it belongs to set, can also add 'private set'
    }

    // auto-implemented property with init keyword
    public string LastName { get; init; }

    // auto-implemented property with a default value
    public int Id { get; set; } = 1000;

    // Property with private set
    public long Phone { get; private set; } // private is not limited to auto properties

    // expression bodied member property
    public string Address
    {
        get => _address;
        set => _address = value; // again, can make private
    }

    public int Zipcode
    {
        get => zipcode;
        set => zipcode = value;
    }

    // Default Constructor
    public Lesson10() { }

    // Constructor using this with variables
    public Lesson10(string firstName, string lastName, int zipcode)
    {
        _firstname = firstName;
        LastName = lastName;
        this.zipcode = zipcode;  // as names are same, need to add 'this' to seperate the variable
    }

    /*
     This method shows how you can change a private set propery,
     but not a property with init
     */
    private void ShowLastAndPhone()
    {
        // LastName = "John";  // can only be done in a constructor
        Phone = 12345678;  // able to assign a value to phone that is set to private up top
    }



}
