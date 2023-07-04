namespace MyFirstApplication;

public class Horses
{
    public string Breed;
    public string MoveType;
    public string HairColors;
    public string NumberOfAge;

    public Horses(string breed, string moveType, string HairColors, string numberOfAge)
    {
        this.Breed = breed;
        this.MoveType = moveType;
        this.HairColors = HairColors;
        this.NumberOfAge = numberOfAge;
    }

 
   
}// end class

public class Foal : Horses
{
    public string Age { get; set; }

    public Foal(string breed, string moveType, string haircolors, string age)
        :base(breed, moveType, "brown and grey", "colt") 
    {}

    public Foal(string breed, string moveType, string age)
        :this(breed, moveType, "brown and grey", "colt")
    {}

    public Foal()
        :this("thoroughbred", "gallops", "colt")
    {}

}// end class
    


