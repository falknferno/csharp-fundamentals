namespace MyFirstApplication;

internal class Lesson17
{
    public void myThrowExample(House house)
    {
        if (house == null)
        {
            // if house is null, it will use the throw, if not, it will give the door color
            throw new NullReferenceException("House object is null");
        }
        else
        {
            Console.WriteLine(house.DoorColor);
        }
    }

    // This example will use a try/catch
    public void MyExceptionExample(House house)
    {
        try
        {
            Console.WriteLine($"The House door color is {house.DoorColor}");
        }
        catch(NullReferenceException ex) //ex allows us to get things like the message, or other things
        {
            Console.WriteLine($"Null Reference was thrown: {ex.Message}");
        }
    }

    public void MyArrayException()
    {
        // Try/Catch/Finally blocks used to evaluate an array and parsing
        string[] names = { "David", "Matt", "Jody" };
        string[] values = { "257", "425", "385" };

        try
        {
            byte beta = byte.Parse(values[1]);
            Console.WriteLine(beta);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Please provide at least 1 argument: {ex.Message}");
        }
        catch(FormatException fe)
        {
            Console.WriteLine($"That is not a number: {fe.Message}");
        }
        catch(OverflowException oe)
        {
            Console.WriteLine($"You have given me more than a byte: {oe.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block is executed");
        }
    }


} // end class
