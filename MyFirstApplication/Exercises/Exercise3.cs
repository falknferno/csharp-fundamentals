

namespace MyFirstApplication;

internal class Exercise3

{
    public void Arithmetic()
    {
        int able = 20, beta = 10;

        int addTotal = able + beta;
        int subtractTotal = able - beta;
        int multiplyTotal = able * beta;
        int divideTotal = able / beta;

        Console.WriteLine($"Addition ={addTotal}, Subtraction = {subtractTotal}");
        Console.WriteLine($"Multiplication ={multiplyTotal}, Division = {divideTotal}");
    }

    public int Modulus(int beta)
    {
        int total = 245 % beta;
        Console.WriteLine(total);
        Console.WriteLine(15);
        Console.WriteLine(456);
        Console.WriteLine(23);
        Console.WriteLine(89);
        return 245 % beta;

    }

    public void Compound(int val1, int val2, int val3, int val4, int val5, int val6)
    {
        val1 += val2 * val3 / val4;
        Console.WriteLine(val1);

        val1 += val5;
        Console.WriteLine(val1);

        val1 -= val6;
        Console.WriteLine(val1);
        

    }





}
