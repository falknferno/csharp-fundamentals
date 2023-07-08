
namespace MyFirstApplication;

public class Boat
{
    public string _boatType;
    public string _travels;
    public string _boatName;

    public Boat(string boatType, string travels, string boatName)
    {
        this._boatType = boatType;
        this._travels = travels;
        this._boatName = boatName;   
    }

    public string BoatType
    {
       get => _boatType;
       set => _boatType = value;
    }

    public string Travels
    {
        get => _travels;
        set => _travels = value;
    }

    public string BoatName
    {
        get => _boatName;
        set => _boatName = value;
    }

    public virtual void BoatCruises()
    {
        Console.WriteLine($"My boat moves {Travels} by rowing with oars.");
    }




}// end class
