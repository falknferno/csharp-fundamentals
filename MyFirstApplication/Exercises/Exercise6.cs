
namespace MyFirstApplication;

public class Exercise6
{
    private string _shoeType;
    private int _shoeSize;

    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }

    public int ShoeSize
    {
        get { return _shoeSize; }
        set { _shoeSize = value; }
    }

    public Exercise6(string shoeType, int shoeSize)
    {
        _shoeType = shoeType;
        _shoeSize = shoeSize;
    }

    public delegate void TryOn(string type);

    public void TryOnShoe(string message)
    {
        Console.WriteLine($"TryOnShoe = {message}");

    }

    
}

