

namespace MyFirstApplication;

internal class Horse
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
    public int Hieght { get; init; }
    public string Breed { get; init; }
    public int LoadCapacity { get; init; }

    public Horse(int hieght, string breed, int loadcapacity)
    {
        Hieght = hieght;
        Breed = breed;
        LoadCapacity = loadcapacity;
    }
}
