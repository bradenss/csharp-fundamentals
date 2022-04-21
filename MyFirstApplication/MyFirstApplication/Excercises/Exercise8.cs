
namespace MyFirstApplication;

internal class Exercise8
{
    /*
     Write a constants at the class level. The constant should be Foot with a
    value of 12 to represent the number of inches in a foot. Write a method
    that takes 1 int parameter and a void return type. This method will convert
    feet to inches. The formula that you would use will be the parameter *
    Foot. Your parameter will represent the number of feet to convert to
    inches. Using a Console WriteLine statement, print the results. Test your
    method using the number 3 to see if you get 36
     */
    public const int Foot = 12;
    private int _inches;
    public Exercise8(int inches)
    {
        _inches = inches;
    }

    public void Question1()
    {
        int total = Foot * _inches;
        Console.WriteLine($"The total inches for {_inches} feet is {total}.");
    }
    /*
     Write a static method that take 2 int parameters and a void return type.
This method will be used to calculate the length and width of a
rectangle/square. This formula is length x width. The first parameter
should represent the length and the second parameter should be the
width. Using a Console WriteLine statement, print the results. Test your
method and add what you used to test as a comment either before the
method or after.
     */

}

