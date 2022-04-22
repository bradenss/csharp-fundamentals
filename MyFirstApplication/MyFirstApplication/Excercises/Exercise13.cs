
namespace MyFirstApplication;

/*
 In your Exercise13.cs file, change your class to an Interface and name it
IMovement. This interface will have 1 property. The property will an int
and called Speed. It will have a get and init.
 */
public interface IMovement
{
    int Speed { get; }
    int QuikSilver();
}

/*
 Under the interface you will create an Abstract class called WaterBirds.
This abstract class will implement the IMovement interface. The interface
property should be implemented in the Abstract class as an abstract
property. Create two abstract methods for the abstract class that is related
to WaterBirds. Create a constructor that will take an int parameter and be
assigned to the Speed property.
 */
internal abstract class WaterBirds : IMovement

{
    public abstract int Speed { get; }
    protected int num;
    protected abstract int Inches { get; }
    protected abstract int Feet { get; }
    protected WaterBirds(int num)
    {
        this.num = num;
    }
    public abstract int Falcon();
    public abstract int Eagles();

    public abstract int QuikSilver();
}

/*
 Under the Abstract class Waterbirds, create a derived class that will extend
the WaterBird class. Implement the abstract methods and property. Use
Console Writeline statements in your methods that provide information
related to the methods. One of them should use an Interpolation string and
consume the Speed property. Create a constructor that will take an int
parameter and use the :base() to pass that int value back to the base
Abstract class.
 */
internal class WaterBirds2 : WaterBirds
{
    protected override int Inches { get; } = 12;
    protected override int Feet { get; } = 3;

    public override int Speed => 1760;
    public WaterBirds2(int value)
        : base(value) { }

    public override int Eagles()
    {
        return num * Inches;
    }

    public override int Falcon()
    {
        return num * Feet;
    }
    public override int QuikSilver()
    {
        return num * Speed;
    }
}
