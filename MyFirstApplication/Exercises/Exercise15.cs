namespace MyFirstApplication;

public enum FavoriteMovies { Superman, Matrix, Transformers, Thor, Bleach }

public class Exercise15
{
    public string ActionMovies(FavoriteMovies movies)
    {
        string message = movies switch
        {
            FavoriteMovies.Superman => $"My favorite movie is {FavoriteMovies.Superman}",
            FavoriteMovies.Matrix => $"My favorite movie is {FavoriteMovies.Matrix}",
            FavoriteMovies.Transformers => $"My favorite movie is {FavoriteMovies.Transformers}",
            FavoriteMovies.Thor => $"My favorite movie is {FavoriteMovies.Thor}",
            _ => $"My favorite movie is {FavoriteMovies.Bleach}"
        };
        return message;
    } 


    public (int, string) AwesomeMovies (FavoriteMovies movie)
    {
        string fm = movie.ToString();
        int able = (int)movie;
        return (able, fm);
    }
    
    
} // end class
