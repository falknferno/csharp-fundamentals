namespace MyFirstApplication;

public class Mustang : Horse
{
    public override void HorseMoves()
    {
        base.HorseMoves();
        Console.WriteLine($"The horse {MoveType} fast through the field.");
    }


}// end class
