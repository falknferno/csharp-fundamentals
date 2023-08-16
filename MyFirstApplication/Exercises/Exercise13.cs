namespace MyFirstApplication;

public interface IMovement
{
    int Speed { get; init; }

} // end interface

public abstract class WaterBirds : IMovement
{
    public int speed;

    public abstract int Speed { get; init; }

    public abstract int SwimTime { get; init; } 
    public abstract int SwimDistance { get; init; }

    public WaterBirds(int speed)
    {
        this.speed = speed;
    }

} // end class

public class WaterBirdsDerived : WaterBirds
{

    public override int SwimTime { get; init; } 
    public override int SwimDistance { get; init; }

    public override int Speed { get; init; } = 6;

    public virtual void WaterBirds()
    {
        Console.WriteLine("The birds can swim fast using their webbed feet and longer legs");
        Console.WriteLine($" The waterbird can swim at a speed of {Speed} miles per hour.");
    }

    public WaterBirdsDerived(int value)
        :base(value) {}

    
} // end class
