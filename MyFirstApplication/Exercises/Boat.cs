
namespace MyFirstApplication;

public class Boat
{
    public string BoatType { get; set; }
    public string Travels { get; set; }
    public string BoatName { get; set; }

    public Boat (string boatType, string travels, string boatName)
    {
        this.BoatType = boatType;
        this.Travels = travels;
        this.BoatName = boatName;   
    }

    public string boatType
    {
        get => BoatType;
        set => BoatType = value;
    }

    public string travels
    {
        get => Travels;
        set => Travels = value;
    }
    
    public string boatName
    {
        get => BoatName;
        set => BoatName = value;
    }


}// end class
