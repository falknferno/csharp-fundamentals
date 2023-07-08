

namespace MyFirstApplication;

internal class Exercise5
{
    public int OhmsLaw(int current, int resistance)
    {
        Func<int, int, int> voltage = (current, resistance) => current * resistance;
        return voltage(current, resistance);

    }
    public string Grades(char value)
    {
        switch (value)
        {
            case 'E':
                return "Excellent";
            case 'V':
                return "Very Good";
            case 'G':
                return "Good";
            case 'A':
                return "Average";
            case 'F':
                return "Fail";
            default:
                return "Not a valid grade";
        }
    }

    public void PopcornSize(int size)
    {
        string result = size switch
        {
            <= 3 => "Microwave Bag",
            <= 16 => "Movie Sack",
            <= 32 => "Movie Cup",
            <= 64 => "Movie Tub",
            _ => "We don't have that size",
        };
        Console.WriteLine(result);
    }



}



