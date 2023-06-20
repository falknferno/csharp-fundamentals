namespace MyFirstApplication;

internal class Exercise8
{
    public const int Feet = 3;
    public const int Inches = 36;

    public const double InchesPerFoot = (double)Inches / (double)Feet;

    public static int InchCount;
    public int _inches;

    public Exercise8(int lengthInches)
    {
        _inches = lengthInches;
    }

    public static int CalculateInchCount()
    {
        return ++InchCount;
    }

    public void CalculateInches()
    {
        int total = Feet * _inches;
        Console.WriteLine($"The total number of {_inches} is {total}");
        CalculateInchCount();
    }

    public static void RectangleAndSquare()
    {
        int length = 8;
        int width = 6;
        int area = length * width;
        Console.WriteLine($"The area of{length} and {width} is {area}");

        /*
         Used a static method and int values to come up with the area of the rectangle/square, with the int value of the area.
         Then used a void return with an interpolation to tell me when I ran it in program.cs.
         */
    }


}


