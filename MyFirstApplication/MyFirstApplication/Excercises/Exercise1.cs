
namespace MyFirstApplication;

internal class Exercise1
{
    /*Write out a method with no arguments and a void return type that will
print the output of the number 35 based on the number systems below.
The values should be assigned to a variable inside the method prior to
printing them using Console WriteLine.Utilize the conversion document
from your resources.
    */

    public void Question1()
    {
        // value of 35
        int value1 = 35; // decimal
        int value2 = 23; // not sure how to make the hexadecimal value, I just got 23?
        int value3 = 00100011; // binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    /*Write a method that will accept 3 argument parameters and a void return
type. The first argument should be of type byte. The second argument
should be of type short. The third argument should be of type int. Using
Implicit conversion, create variables to convert to using the below
information. Use the argument parameters as the values to convert from.
Print each converted variable using Console WriteLine.
a. From byte to int
b. From short to long
    */
    // Part A
    public void Question2(int myInt)
    {
        int converted = (int)myInt;
        Console.WriteLine(converted);
    }
    // Part B
    public void Question2b(long myShort)
    {
        long converted = (long)myShort;
        Console.WriteLine(converted);
    }
    // Part C
    public void Question2c(float myFloat)
    {
        float converted = (float)myFloat;
        Console.WriteLine(converted);
    }
    /*Write a method that will accept 3 argument parameters and a void return
type. The first argument should be of type double. The second argument
should be of type float. The third argument should be of type long. Using
Explicit conversion, create variables to convert to using the below
information. Use the argument parameters as the values to convert from.
Print each converted variable using Console WriteLine.
a. From double to long
b. From float to int
c. From long to short
    */

    // Part A
    public void Question3(long myDouble)
    {
        long converted = (long)myDouble;
        Console.WriteLine(converted);
    }
    // Part B
    public void Question3b(int myFloat)
    {
        int converted = (int)myFloat;
        Console.WriteLine(converted);
    }
    // Part C
    
    public void Question3c(short myLong)
    {
        short converted = (short)myLong;
        Console.WriteLine(converted);
    }
    /* a method with no arguments and a void return type.Using the
    values below, assign them to a variable that best suits their value type.
    Utilize the digit separator when assigning them to your variables.Once you
    have defined your variables, print out each one using Console WriteLine.Do
    not use the same value type more than once.
    a. 123456.987
b. -9516248
c. 3500
d. 988562486
e. -19733.14895     
    */

    public void Question4(decimal arg)
    {
        Console.WriteLine(Decimal.MinValue);
        Console.WriteLine(Decimal.MaxValue);
    }

    public void Question4b(long arg)
    {
        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);
    }


    public void Question4c(UInt16 arg)
    {
        Console.WriteLine(UInt16.MinValue);
        Console.WriteLine(UInt16.MaxValue);
    }
    

    public void Question4d(UInt32 arg)
    {
        Console.WriteLine(UInt32.MinValue);
        Console.WriteLine(UInt32.MaxValue);
    }

    public void Question4e(decimal arg)
    {
        Console.WriteLine(Decimal.MinValue);
        Console.WriteLine(Decimal.MaxValue);
    }
}
