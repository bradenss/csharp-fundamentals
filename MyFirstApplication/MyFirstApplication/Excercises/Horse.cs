

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

    public Horse()
    {
        Hieght = 10;
        Breed = "Race Horse";
        LoadCapacity = 200;
    }
    public Horse(int hieght, string breed, int loadcapacity)
    {
        Hieght = hieght;
        Breed = breed;
        LoadCapacity = loadcapacity;
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

    public Yak(int speed)
    { 
        Speed = speed;
        Hieght = 10;
        Breed = "Norwegian";
        LoadCapacity = 500;
    }
    public Yak()
       : this(8)
    { }
        
    
}