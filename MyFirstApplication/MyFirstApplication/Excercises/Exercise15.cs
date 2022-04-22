

namespace MyFirstApplication;

/*
 Above the class, write an enum called Favorite Movies. Add your own
favorite movies to the enum. Write a method that has a string return type
and an enum parameter. This enum parameter will be your favorite movie
enum. Write a switch expression that takes the enum and prints out a
string return. Use string interpolation in your return message that includes
the name of the movie chosen.

 */

public enum FavoriteMovie { LOTR, Harry_Potter, Shrek}
internal class Exercise15
{
    public void FavoriteMovies()
    {
        Console.WriteLine(FavoriteMovie.LOTR);
        Console.WriteLine((double)FavoriteMovie.Shrek);
    }

    // Enum using a switch expression to narrow doen the choices
    public string Question1(FavoriteMovie favorite)
    {
        string message = favorite switch
        {
            FavoriteMovie.LOTR => $"My favorite is {FavoriteMovie.LOTR}",
            _ => $"My favorite is {FavoriteMovie.Harry_Potter}"
        };
        return message;
    }

    /*
     Write a method that takes an enum parameter. This enum will be your
favorite movie enum. The method will have a tuple return type (int num,
string movie). Using an explicit int cast on one of your enum, assign the
value to an int variable. Create second variable of type string. Assign the
same enum value you used and use the ToString() at the end of it. Return
both variables as a tuple. See example below for clarity.
a. Int value = (int)Enum.Value;
b. string something = Enum.Value.ToString();
     */
    public (int able, string beta) Question2(int value1, string value2)
    {
        int alpha;
        string bravo;
        if (value1 <= 10) value2 = $"Learn";
        {
            alpha = ++value1;
            bravo = value2;
        } 
        
        {
            alpha = 4;
            bravo = $"CSharp";
        }
        return (alpha, bravo);
    }
}
