

namespace MyFirstApplication;

public class Horse
{
    public string Breed { get; init; }
    public string MoveType { get; init; }
    public string HairColor { get; init; }

    public Horse(string breed, string moveType)
        :this(breed, moveType, "Brown")
    {}

    public Horse()
        :this("thorougbred", "gallops")
    {}

    public Horse(string breed, string moveType, string hairColor)
    {
        this.Breed = breed;
        this.MoveType = moveType;
        this.HairColor = hairColor;
    }

    



}// end class


