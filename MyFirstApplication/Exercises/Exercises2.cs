

namespace MyFirstApplication;

internal class Exercises2
{
    string myString = "Hello World";

    public void myTrimExample()
    {
        string str = " Exercise two Lab ";
        Console.WriteLine(str);
        string myTrim = str.Trim();
        Console.WriteLine(myTrim);
    }

    public void MyContainsExample(string alpha)
    {
        Console.WriteLine(alpha.Equals("tow"));
    }

    public void MyLowerExample()
    {
        Console.WriteLine(myString.ToLower());
    }

    public int MyStringLength()
    {
        return myString.Length;
    }

    public void MyExampleChar()
    {
        char myChar = ('C');
        char pilcrow = '\u00b6';
        Console.WriteLine(myChar);
        Console.WriteLine(pilcrow);

    }

    public string MyEscapeExample()
    {
        return "Jack and Jill \nwent up the hill \nto fetch a bowl of water. \nJack fell down and brok his crown \nand Jill came tumbling after.";
           
    }

    public string MyInterpolationExample(string name, string movie, string snack, string drink)
    {
        return $"My name is {name}, my favorite movie is {movie}, my favorite snack are {snack}, and my favorite drink \nis {drink}";

    }

    
}

