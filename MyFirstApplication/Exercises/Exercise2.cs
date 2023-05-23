

namespace Exercises;

internal class Exercise2
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
        return "Jack and Jill /nwent up the hill /nto fetch a pale of water." +
            "/nJack fell down and broke his crown /nand Jill came tumbling after.";
    }

    public string MyInterpolationExample(string name, string movie, string snack, string drink)
    {
        return $"My name is {name}, my favorite movie is{movie}, my favorite \tsnack \nis" +
            $"{snack}, and my favorite drink is {drink}.";
    }

    
}

