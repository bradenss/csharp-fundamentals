

namespace MyFirstApplication;

public class Horse
{
    /*
     Create a class based on your Horse object. Include your attributes as auto
properties. Create 3 constructors. The first constructor should have
parameters equal to your properties. Assign each parameter to your
properties. The second constructor should have 2 parameters. Using the
:this() keyword, you will pass your information to the first constructor. This
includes the 2 parameters and default values. For the last constructor, you
will create the default constructor. Using the :this() keyword, you will pass
2 default values in that will pass to the 2nd constructor. Also include in the
class, your method for Horse
     */
    public int Hieght { get; set; }
    public string Breed { get; set; }
    public int LoadCapacity { get; set; }

    /*
     In your Horse class, add the virtual keyword to your method created in
Lesson 10. Create a second version of the same method and add a
parameter. Include a Console WriteLine method in the new method that
uses the parameter. This parameter needs to be based on one of your
properties.
     */
    private int _jumphieght;
    public int JumpHieght
    {
        get { return _jumphieght; }
        set { _jumphieght = value; }
    }

    public Horse()
    {
        JumpHieght = 10;
        Hieght = 10;
        Breed = "Race Horse";
        LoadCapacity = 200;
    }
    public Horse(int hieght, string breed, int loadcapacity, int _jumphieght)
    {
        JumpHieght = _jumphieght;
        Hieght = hieght;
        Breed = breed;
        LoadCapacity = loadcapacity;
    }
    public virtual void JumpHieght1()
    {
        Console.WriteLine($"Wow the {Breed} can jump {JumpHieght!}");
    }

}

/*
Create a child class based on your Horse object. Include one child attribute
as an auto property. Create 3 constructors. The first constructor should
have 4 parameters with 3 of them from Horse and your child property.
Using the keyword :base() ,you will put the four horse parameters in the
parenthesis. In the body of the constructor you will assign your child
parameter to your property.
The second constructor should have 2 parameters, 2 based on the horse
and 1 from your child. Using the :this() keyword , you will pass 2 of the
parent attributes and your child attribute information to the first
constructor. Include default values to represent the 2 remaining horse
parameters.
For the last constructor, you will create the default constructor. Using the
:this() keyword, you will pass 2 default values in that will pass to the 2nd
constructor. Also include in the class, your method for your child class.
 */

public class Yak : Horse
{
    public int Speed { get; init; }
    /*
     In your child class of Horse, using the override keyword create a method
that has the same name as the virtual method from Horse. Add a Console
WriteLine that provides a different message from the Horse.
     */
    private int _jumphieght;

    public Yak(int speed, int _jumphieght)
    {
        JumpHieght = _jumphieght;
        Speed = speed;
        Hieght = 10;
        Breed = "Norwegian";
        LoadCapacity = 500;
    }
    public Yak()
       : this(8, 10)
    { }
    

    public override void JumpHieght1()
    {
        base.JumpHieght1();
        Console.WriteLine($"That is a {Breed}.");
    }

}