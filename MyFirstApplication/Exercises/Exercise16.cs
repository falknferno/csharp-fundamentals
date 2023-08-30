namespace MyFirstApplication;

public class Exercise16
{
    public void myHorseList()
    {
        List<string> myHorseList = new List<string>();
        myHorseList.Add("Thoroughbred");
        myHorseList.Add("Grey");
        myHorseList.Add("Gallops");
        myHorseList.Add("Fast");

        foreach (string horse in myHorseList)
        {
            Console.WriteLine(horse);
        }
    }

    public void myDictionary()
    {
        Dictionary<int, string> movies = new Dictionary<int, string>();
        movies.Add(1, "Superman");
        movies.Add(2, "Matrix");
        movies.Add(3, "Transformers");
        movies.Add(4, "Thor");

        foreach (KeyValuePair<int, string> item in movies)
        {
            Console.WriteLine($"Cue: {item.Key}    Movie: {item.Value}");
        }

    } 

}// end class
