namespace MyFirstApplication;

public class Horse
{
    public string Breed { get; init; }
    public string MoveType { get; init; }
    public string HairColors { get; init; }

    public Horse(string breed, string moveType, string hairColors)
    {
        this.Breed = breed;
        this.MoveType = moveType;
        this.HairColors = hairColors;
    }

    public Horse(string breed, string moveType)
        :this(breed, moveType, "brown and grey")
    {}

    public Horse()
        :this("Thorougbred", "gallops")
    {}

    public virtual void HorseMoves()
    {
        Console.WriteLine($"My horse {MoveType} very fast.");
    }



    



}// end class


