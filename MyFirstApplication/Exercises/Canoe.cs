namespace MyFirstApplication;

public class Canoe : Boat
{
    public string _oars;

    public string Oars
    {
        get { return _oars; }
        set { _oars = value; }
    }

    public Canoe(string oars)
        :this("kayak", "slow", "Falkn", oars)
    {}

    public Canoe(string boatType, string travels, string boatName, string oars) 
        :base(boatType, travels, boatName)
    {
        _oars = oars;
    }

    public override void BoatCruises()
    {
        base.BoatCruises();
        Console.WriteLine($"With my boat, it's {Travels} by rowing with the oars.");
    }

}