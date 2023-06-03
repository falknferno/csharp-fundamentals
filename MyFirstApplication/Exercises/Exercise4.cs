

using DocumentFormat.OpenXml.Bibliography;

namespace MyFirstApplication;

internal class Exercise4
{
    public void IfElse(int alpha, int beta)
    {
        if (alpha > 13 && beta <= 38) // boolean and string
        {
            Console.WriteLine($"My {alpha} is greater than 13, and {beta} is equal to 38");
        }
        else
        {
            Console.WriteLine($"My {alpha} is greater than 13, and {beta} is equal or less than 38");
        }

        Console.WriteLine($"Number equals {alpha} and {beta}");

    }

    public string GradeCheck(char value)
    {
        switch (value)
        {
            case 'E':
                return "Exellent";
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

    public void Divisor()
    {
        for (int i = 0; i <= 30; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine($"Number = {i}");
            }
        }
    }
        
    
            
        
}
