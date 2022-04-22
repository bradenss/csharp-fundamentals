
namespace MyFirstApplication;

internal class ExerciseBoat1
{
    /*
     Create a class based on your Boat object. You will follow the same
instructions as exercise 1 except for the following. Include your attributes
as Expression Body Definition Properties.
     */

    public int Size { get; init; }
    public string Type { get; init; }
    public int LoadCapacity { get; init; }
    public ExerciseBoat1()
       : this(750, "CargoShip", 200000)
    { }
    public ExerciseBoat1(int size, string type, int loadcapacity)
    {
        Size = size;
        Type = type;
        LoadCapacity = loadcapacity;
    }
    
    public void BoatAnswer()
    {
        Console.WriteLine($"My boat\'s size is {Size}ft long!");
        Console.WriteLine($"My boat is a {Type}.");
        Console.WriteLine($"My boat can carry {LoadCapacity}lbs!");
    }
    


}
