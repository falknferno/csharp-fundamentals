

namespace MyFirstApplication;

public record struct BoatExercise()
{
    public void CalculateSize(int width, int length)
    {
        int total = length * width;
        {
            Console.WriteLine($" The boat is {total} square feet in size");
        }
       
    }

    
}
