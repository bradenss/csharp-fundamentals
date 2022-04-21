
namespace MyFirstApplication;

internal class Exercise2
{

    /*Write a method that takes a string argument parameter and void return
type. Using string concatenation and the below string methods, write a
Console WriteLine statement for each of them. Inside the string
concatenation will be the name of each string method. When testing this
method use the following string “ EXERCISE two Lab “. Do not copy and
paste this in Visual Studio. It will not paste correctly.
  */
    // Question1
    public void Question1(string alpha)
    {
        Console.WriteLine("ToUpper" + alpha.ToUpper());
        Console.WriteLine("ToLower" + alpha.ToLower());
        Console.WriteLine("Contains" + alpha.Contains("tow"));
        Console.WriteLine("The Length is" + alpha.Length);
        Console.WriteLine(alpha.IndexOf('C'));
    }

    /* Write a method that takes no arguments and a void return type. Using the
    Unicode table resource link, assign the Unicode value of the Pilcrow Sign to
a variable.Use the Console WriteLine to print that variable.This variable
should utilize the type that takes 1 character.
    */
    public void Question2()
    {
        char myPilgrim = '\x00B6';
        Console.WriteLine(myPilgrim);
    }

    /*Write a method that takes no arguments and a void return type. Use 1
string variable and 1 Console WriteLine to complete this task. Use escape
sequences to achieve the below results.
    */
    public string Question3()
    {
        return "Jack and Jill \nwent up the hill \nto fetch a pail of water." +
            "\nJack fell down and broke his crown \nand Jill came tumbling after.";
    }

    /*Write a method that takes no arguments but does have a string return
type. You will utilize Interpolation to complete this task. Create variables
for each provided data below. Using Interpolation return a string that
includes the variables in a sentence.
    */
    public string Question4(string name)
    {
        return $"My name is {name}.";
    }

    // Part B
    public string Question4b(string movie)
    {
        return $"My Favorite movie is {movie}.";
    }

    // Part C
    public string Question4c(string snack)
    {
        return $"My Favorite movie snack is {snack}.";
    }
    // Part D
    public string Question4d(string drink)
    {
        return $"My Favorite movie drink is {drink}";
    }
}