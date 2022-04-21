
namespace MyFirstApplication;

/*
  This lesson goes over Expressions % Pattern Matching.
  It will a lso inclue an intro to delegates.
  */
internal class Lesson5
{
    // Delegate
    public delegate void Del(string message);
    /*
     The is operator checks if the result of an expression
    is compatiblr with another type.
    */
    public void IsOperatorExample(int able)
    {
        object bravo = able;

        Console.WriteLine(bravo is int);
        Console.WriteLine(bravo is long);
    }

    /* Creat a method for delegate example
     */
    public void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }
    /*
     Method for func delegate
    */
    public int Sum(int beta)
    {
        return beta * 2;
    }
    /*
     Lamda using the Func Delegate
    */
    public void LambdaSquare()
    {
        Func<int, int> square = able => able * able;
        Console.WriteLine(square(4));
    }

    /*
     Lambda using the Action Delegate
    */
    public void LambdaGreeting()
    {
        Action<string> greet = name =>
        {
            string greeting = $"Hello {name}! We are learning.";
            Console.WriteLine(greeting);
        };

        greet("lambda");
    }

    /* Basic Switch */
    public string BasicSwitch(string able)
    {
        switch(able)
        {
            case "blue":
                return "Favorite color is blue";
            case "red":
                return "Favorite color is red";
            case "green":
                return "Favorite color is green";
            default:
                return "not sure";
        }
    }

    /* Switch Expression based on above switch*/
    public string Favoritecolor(string charlie)
    {
        string result = charlie switch
        {
            "blue" => "Favorite color is blue",
            "red" => "Favorite color is red",
            "green" => "Favorite color is green",
            _ => "not sure"
        };

        return result;
    }
    /* 
     Relational Pattern compares an expression result with a constant.
     */
    public void DrinkSize(int size)
    {
        string result = size switch
        {
            <= 20 => "Can",
            <= 32 => "bottle",
            <= 64 => "Big Gulp",
            _ => "We dont have tat size."
        };
        Console.WriteLine(result);
    }
    /*
     Logical pattern And matches an expression when both patterns match 
    the expresion
     */
    public void TemeratureGuide(double temp)
    {
        string result = temp switch
        {
            > -10.0 and < 0 => "Negative Cold",
            >= 0 and < 32.0 => "Freezing Cold",
            >= 32.0 and < 49.0 => "Cold",
            >= 49.0 and < 60.0 => "Warm",
            >= 60.0 and <90.0 => "Nice",
            >= 90.0 and < 105.00 => "Too Hot",
            _ => "Unknown"
        };
        Console.WriteLine(result);
    }
    /*
     Logical Pattern OR matches an experssion when either pattern
    matches the expression.
     */
    public void NumberChoice(int able)
    {
        string result = able switch
        {
            1 or 2 => $"{able} is 1 or 2",
            3 or 4 => $"{able} is 3 or 4",
            5 => $"{able} is 5",
            _ => $"{able} was not on the list"
        };
        Console.WriteLine(result);
    }
}
