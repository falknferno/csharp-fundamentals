

namespace MyFirstApplication;

public record struct Boat(int width, int length)
{
    public void CalculateBoat()
    {
        Console.WriteLine(width * length);
    }
}
