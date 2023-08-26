namespace MyFirstApplication;

internal class Exercise14
{
    public void SingleFlavorsArray()
    {
        string[] flavors = { "vanilla", "caramel", "toffee", "butterscotch" };
         
        foreach (string flavor in flavors)
        {
            Console.WriteLine($"{flavor}");
        }
    }

    public void MultiIntArrays()
    {
        int[,] footballScores = { {34,20}, {23,20}, {34,20}, {26,10}, {32,40}, {26,17},
            {43,16}, {35,9}, {33,31}, {35,31}, {27,24}, {22,16}, {33,27}, {32,29},
            {17,14}, {21,38} };

        for(int i = 0; i < footballScores.GetLength(0); i++)
        {
            for(int k = 0; k < footballScores.GetLength(1); k++)
            {
                if (i % 1 == 0 && k % 2 == 0)
                {
                    Console.Write($"Home Team: {footballScores[i,k]}   ");
                }
                else
                {
                    Console.WriteLine($"Away Team: {footballScores[i,k]} ");
                }
            }
        }
        
    }
    


} // end class
