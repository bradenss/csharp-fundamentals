
namespace MyFirstApplication;

/*
 This class goes over Strings
*/
internal class Lesson2
{
    string myString = "Hello World";

    // String Method - Trim
    public void MyTrimExample()
    {
        string str = " World ";
        // before trim
        Console.WriteLine(str);
        // trim
        string myTrim = str.Trim();
        // after trim
        Console.WriteLine(myTrim);
    }

    // String method - Equals
    public void MyEqualsExample(string beta)
    {
        Console.WriteLine(beta.Equals("World"));
    }

    // String Methods To Upper and To Lower
    public void MyUpperLowerExample()
    {
        Console.WriteLine(myString.ToUpper());
        Console.WriteLine(myString.ToLower());
    }
    // String Method _ Length
    public int MyStringLength()
    {
        return myString.Length;
    }

    // Char - Uses single quotes
    public void MyExampleChar()
    {
        char myChar = 't';
        char copyright = '\u00A9';
        char something = '\x00A9';
        Console.WriteLine(something);
        Console.WriteLine(copyright);
        Console.WriteLine(myChar);
    }

    // Escape Sequence
    public string myEscapeExample()
    {
        return "that\'s a cool car. \tCan I \ndrive it sometime?";
    }
    // Concatenation - with 2 string parameters
    public void MyJoinedStrings(string value1, string value2)
    {
        Console.WriteLine(value1 + " " + value2);
    }
    public string MyInterpolationExample(string food, int amount)
    {
        return $"My Favorite food is {food} and I ate {amount} servings of it";
    }

    // ($"|{"Number", -10} | {"Order", 15}|");
    public void MyOtherInterpolation()
    {
        Console.WriteLine($"|{"Number",-10} | {"Order",15}|");
    }
}

