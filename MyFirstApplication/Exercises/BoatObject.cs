

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

public class Canoe : Boats
{
    public string SmallBoat
    {
        get => SmallBoat;
        set => SmallBoat = value;
    }

    public Canoe(string boatType, string boatName, string travels, string smallBoat)
        :base(boatType, boatName, travels, )

}// end class
