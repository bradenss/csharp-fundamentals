

namespace MyFirstApplication;

/*
 This will be about Abstract modifier and Interfaces
 */

public interface ILesson13Interface
{
    int Miles { get; }
    int ConvertMilesToYards();
}
internal abstract class Lesson13Base : ILesson13Interface
{
    protected int num;

    // Abstract Properties
    protected abstract int Inches { get; }
    protected abstract int Feet { get; }
    
    //Implmented from interface
    public abstract int Miles { get; }

    protected Lesson13Base(int num)
    {
        this.num = num;
    }

    // Abstract Methos
    public abstract int ConvertFeetToInches();
    public abstract int ConvertYardstoFeet();

    // Implemented from interface
    public abstract int ConvertMilesToYards();
}

/*
 * Our derived class will implement our Abstract class members.
 */

internal class Lesson13Derived : Lesson13Base
{
    // implementing abstrat properties
    protected override int Inches { get; } = 12;
    protected override int Feet { get; } = 3;

    // implementing interface
    public override int Miles => 1760;
    public Lesson13Derived(int value)
        :base(value){ }

    // Implemented abstract methods
    public override int ConvertFeetToInches()
    {
        return num * Inches;
    }

    public override int ConvertYardstoFeet()
    {
        return num * Feet;
    }

    // Implemented interface method
    public override int ConvertMilesToYards()
    {
        return num * Miles;
    }
}