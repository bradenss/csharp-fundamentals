
namespace MyFirstApplication;

internal class Exercise5
{
    /*
     Write a method that takes 2 int parameters and an int return type. Using
the formula below from Ohm’s law, determine the voltage. The first
method parameter will represent current and the second parameter will
represent resistance. Using the Func<int, int, int> and a lambda
expression, determine the voltage calculation and return the value.
a. Voltage = Current x Resistance
     */
    // Can't figure this one out
    public void Question1()
    {
        Func<int, int> voltage = able => able * able;
        Console.WriteLine(voltage(12));
    }
    /*
     Write a method that will take 1 char parameter and a string return type.
Using a switch expression and the table below, return the description. If
the value does not match the grade, return the default message, “Not a
valid grade”.
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
    /*
     Write a method that takes 1 argument and a void return type. Using a
Relational Pattern and switch expression determine a size of popcorn
based on the table below and using a Console WriteLine, print the popcorn
size.
Size Size Value
Less or equal 3 Microwave bag
Less or equal 16 Movie sack
Less or equal 32 Movie cup
Less or equal 64 Movie tub
Default We don’t have that size
     */
    public void Question3(int size)
    {
        string result = size switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie sack",
            <= 32 => "Movie cup",
            <= 64 => "Movie tub",
            _ => "We dont have that size."
        };
        Console.WriteLine(result);
    }
}
