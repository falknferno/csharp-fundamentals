
namespace MyFirstApplication;

public class House
{
    /*
     This was updated to change the properties, making auto properties
     */
    public string Foundation { get; init; } //changed the lowercases up uppercases
    public string RoofType { get; init; }
    public string DoorColor { get; init; }
    public int WindowSize { get; init; }  // then create a constructor to allow to set all values

    public House()   // Default constructor
        :this("concrete", "shingle")  // adds to foundation and roofType
    {}

    public House(string foundation, string roofType)  // what changes here is adding ':this'
        :this(foundation, roofType, "Red", 25) // adds to doorColor and windowSize
    {}


    public House(string foundation, string roofType, string doorColor, int windowSize)
    {
        this.Foundation = foundation;
        this.RoofType = roofType;
        this.DoorColor = doorColor;
        this.WindowSize = windowSize;
    }

    public void DoorOpenClose()
    { 
        // added interpolation and DoorColor
        Console.WriteLine($"My {DoorColor} door is open."); // then add to each constructor in program.cs
    }
}

