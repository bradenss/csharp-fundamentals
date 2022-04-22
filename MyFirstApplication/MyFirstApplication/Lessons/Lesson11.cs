
namespace MyFirstApplication;

public class Polygon
{
    // properties
    protected int NumberOfSides { get; set; }

    /*
     Base constructor. If a derived class does not implement
    a base class constructor explcity, the base constructor
    is called implicitly.
     */
    public Polygon()
    {
        NumberOfSides = 1;
    }

    internal double CalculateInteriorAngle()
    {
        return (NumberOfSides - 2) * 180 / NumberOfSides;
    }
    
}

// Square is the derived class of Polygon
public class Square : Polygon
{
    public Square()
    {
        NumberOfSides = 4;
    }
}

// Triangle is the derived class of Polygon
public class Triangle : Polygon
{
    public Triangle()
    {
        NumberOfSides = 3;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
