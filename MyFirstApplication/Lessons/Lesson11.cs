namespace MyFirstApplication;

public class Polygon
{
    //Properties
    protected int NumberOfSides { get; set; }

    /*
      Base constructor. If a derived class does not implement a base class
      constructor explicitly, the base constructer is is called implicitly
     */
    public Polygon()
    {
        NumberOfSides = 1;
    }

    internal double CalculateInteriorAngle()
    {
        return (NumberOfSides - 2) * 180 / NumberOfSides;
    }


}// end class

// Square is the derived class of Polygon
public class Square : Polygon
{
    public Square()
    {
        NumberOfSides = 4;
    }

}

// Triangle is the derived class of Polygon
public class Triangle : Polygon
{
    public Triangle()
    {
        NumberOfSides = 3;
    }
}
