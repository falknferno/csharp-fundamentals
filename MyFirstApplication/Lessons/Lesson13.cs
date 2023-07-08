namespace MyFirstApplication;

/*
 This will be about Abstract modifier and Interfaces
 */
internal abstract class Lesson13Base
{
    protected int num;

    // Abstract properties

    protected abstract int Inches { get; }
    protected abstract int Feet { get; }

    protected Lesson13Base(int num)
    {
        this.num = num;
    }

    // Abstract Methods
    public abstract int ConvertFeetToInches();
    public abstract int ConvertYardsToFeet();

}// end class

/*
 Our derived class will implement our Abstract class members
 */

internal class Lesson13Derived: Lesson13Base  // derived will also ask for constructor, as we do not have a default constructor
{
    // implementing abstract properties
    protected override int Inches { get; } = 12;
    protected override int Feet { get; } = 3;

    public Lesson13Derived(int value)
        :base(value) { }

    // Implementing abstract methods
    public override int ConvertFeetToInches()
    {
        return num * Inches;
    }

    public override int ConvertYardsToFeet()
    {
        return num * Feet;
    }


}// end class
