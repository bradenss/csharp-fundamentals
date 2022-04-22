
namespace MyFirstApplication;

public class ExerciseBoat1
{
    /*
     Create a class based on your Boat object. You will follow the same
instructions as exercise 1 except for the following. Include your attributes
as Expression Body Definition Properties.
     */

    public int Size { get; init; }
    public string Type { get; init; }
    public int LoadCapacity { get; init; }
    /*
     In your Boat class, add the virtual keyword to your method created in
Lesson 10. Create a second version of the same method and add a
parameter. Include a Console WriteLine method in the new method that
uses the parameter. This parameter needs to be based on one of your
properties.

     */
    private string _hullshape;
    public string HullShape
    {
        get { return _hullshape; }
        set { _hullshape= value; }
    }
  
    public ExerciseBoat1()
       : this(750, "CargoShip", 200000, "W")
    { }
    public ExerciseBoat1(int size, string type, int loadcapacity, string _hullshape)
    {
        Size = size;
        Type = type;
        LoadCapacity = loadcapacity;
        HullShape = _hullshape;
    }
    public virtual void HullShape1()
    {
        Console.WriteLine($"That {Type} of a ship has a {HullShape!} hull");
    }
    public void BoatAnswer()
    {
        Console.WriteLine($"My boat\'s size is {Size}ft long!");
        Console.WriteLine($"My boat is a {Type}.");
        Console.WriteLine($"My boat can carry {LoadCapacity}lbs!");
    }
}

public class TugBoat : ExerciseBoat1
    {
    public int Speed { get; init; }
    /*
     In your child class of Boat, using the override keyword create a method
that has the same name as the virtual method from Boat. Add a Console
WriteLine that provides a different message from the Boat.
     */
    private int _hullshape;

    public TugBoat(int speed, string _hullshape)
    {
        HullShape = _hullshape;
        Speed = speed;
        Size = 10;
        Type = "TugBoat";
        LoadCapacity = 20000;
    }
    public TugBoat()
       : this(8, "v")
    { }
    public override void HullShape1()
    {
        base.HullShape1();
        Console.WriteLine($"That is a {HullShape}.");
    }
}
