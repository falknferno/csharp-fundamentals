namespace MyFirstApplication;

public class Boats
{
    public string BoatType;
    public string BoatName;
    public string Travels;
    public string BoatSize;

    public Boats(string boatType, string boatName, string travels, string boatSize)
    {
        this.BoatType = boatType;
        this.BoatName = boatName;
        this.Travels = travels;
        this.BoatSize = boatSize;
    }
   
}// end class

public class Dinghy : Boats
{
    public string _smallBoat;
    public string SmallBoat
    {
        get => _smallBoat;
        set => _smallBoat = value;
    }

    public Dinghy(string boatType, string boatName, string travels, string smallBoat)
        :base(boatType, boatName, travels, "runAbout")
    {
        _smallBoat = smallBoat;
    }

    public Dinghy(string boatType, string boatName)
        :this(boatType, boatName, "fast over water", "runAbout")
    {}

    public Dinghy()
        :this("Speed Boat", "Falcon")
    {}

}// end class
