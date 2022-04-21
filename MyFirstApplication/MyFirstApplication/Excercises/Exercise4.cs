
namespace MyFirstApplication;

internal class Exercise4
{
    /*Write a method that takes 2 string arguments and a void return type.
    Using and if-else statement, compare the two strings to each other.Using a
Console WriteLine statement, print out the results of whether the strings
are equal.Provide a comment inside the method that says what strings
you used during testing.
    */

    public void Question1(int beta)
    {
        if (beta >= 12)
        {
            Console.WriteLine($"{beta} is equal with the statement.");
        }
        else
        {
            Console.WriteLine($"{beta} was greater than the statment.");
        }
    }
    /*Write a method that will take 1 char argument and a string return type.
Using a switch and the table below, return the description. If the value
does not match the grade, return the default message, “Not a valid grade”.
    */
    public void Question2(string grade)
    {
        switch (grade)
        {
            case "E":
                Console.WriteLine($"{grade} is an excellent grade.");
                break;
            case "V":
                Console.WriteLine($"{grade} is a very good grade.");
                break;
            case "G":
                Console.WriteLine($"{grade} is a good grade.");
                break;
            case "A":
                Console.WriteLine($"{grade} is an average grade.");
                break;
            case "F":
                Console.WriteLine($"{grade} is failure grade.");
                break;
            default:
                Console.WriteLine($"{grade} is not a valid grade.");
                break;
    }
        
    }
    /* Write a method that takes no arguments and a void return type. Using an
    iteration statement, display all the numbers divisible by 3 from 0 to 30.
Utilize a modulus to obtain your results.
    */
    public void Question3()
    {
        for (int x = 0; x < 30; x++)
        {
            if (x % 3 == 0)
            {
                Console.WriteLine($"Number = {x}");
            }
        }
    }
}