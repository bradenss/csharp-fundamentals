
namespace MyFirstApplication;

internal class Exercise2
{
    // Question1
    // Part A
    public void MyTrim()
    {
        string str = " EXERCISE two lab ";
        // before trim
        Console.WriteLine(str);
        // trim
        string myTrim = str.Trim();
        // after trim
        Console.WriteLine(myTrim);
    }

    // Part B
    public void MyLower()
    {
        Console.WriteLine(myString.ToLower());
    }

    // Part C
    public void MyEquals(string beta)
    {
        Console.WriteLine(beta.Contains("tow"));
    }

    // Part D
    public int MyStringLength()
    {
        return myString.Length;
    }

    // Part E
    public void MyEquals(string beta)
    {
        Console.WriteLine(beta.IndexOf('C'));
    }

    // Question 2
    public void MyChar()
    {
        char myPilgrim = '\0x00B6';
        Console.WriteLine(myPilgrim);
    }

    // Question 3
    public string myJackandJillSong()
    {
        return "Jack and Jill \nwent up the hill \nto fetch a pail of water." +
            "/nJack fell down and broke his crown \n and Jill came tumbling after.";
    }

    // Question 4
    // Part A
    public string MyName(string food)
    {
        return $"My name is {name}.";
    }

    // Part B
    public string MyFavoriteMovie(string movie)
    {
        return $"My Favorite movie is {movie}.";
    }

    // Part C
    public string MyFavoriteSnack(string snack)
    {
        return $"My Favorite movie snack is {snack}.";
    }
    // Part D
    public string MyFavoriteDrink(string drink)
    {
        return $"My Favorite movie drink is {drink}";
    }
}