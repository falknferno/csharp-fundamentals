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


}


