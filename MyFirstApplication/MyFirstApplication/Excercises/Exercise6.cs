

namespace MyFirstApplication;

    internal class Exercise6
    {
    /*
    Write a constructor for your exercise file that takes 2 parameters. The first
    parameter should have an int type and a variable name of showSize. The
    second parameter should have a string type and a variable name of
    shoeType. Create private class variables for these types and use and
    underscore when defining them. Inside the constructor associate the class
    variables with the constructor parameters. 
    */
    public delegate void TryOn(string type);
    private string _stringType;
    private int _intSize;
    public string shoeType
        {
            get { return _stringType; }
            set { _stringType = value; }
        }

        public int shoeSize
        {
            get { return _intSize; }
            set { _intSize = value; }
        }

    public Exercise6(string shoeType, int shoeSize)
        {
            _stringType = shoeType;
            _intSize = shoeSize;
        }
    /*
     Write the properties for the class variables defined in exercise 1. Ensure
they are labeled as public and are spelled using a capital letter.
     */
    // not sure what you mean will try and come back to this one
    /*
     Write a delegate that takes a string parameter. This delegate should be
named TryOn. Write a method that takes a string argument and void
return type. In the method body include a Console WriteLine statement
that will print the message. Test your delegate in Program.cs to ensure
everything works properly. Using a mult-line comment on your
Exercise6.cs file, provide the information you used to test the delegate.
     */
    /*
     I tested the delegates by creating a new method in the program.cs file that 
    then calls back to here for the message below which then displays the info
    in the console.
     */
    public void TryOnShoe(string message)
    {
        Console.WriteLine($"TryOnShoe = {message}");
    }
}

