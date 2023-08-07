namespace MyFirstApplication;

public class Canoe : Boat
{
    public Canoe(string boatType, string travels, string boatName) 
        : base(boatType, travels, boatName)
    { }

    public override void BoatCruises()
    {
        base.BoatCruises();
        Console.WriteLine($"With my boat, it's {Travels} by rowing with the oars.");
    }

}