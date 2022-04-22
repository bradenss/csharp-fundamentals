
namespace MyFirstApplication;

public class House
{
    public string Foundation { get; set; }
    public string RoofType { get; set; }
    public string DoorColor { get; set; }
    public int WindowSize { get; set; }

    public House()
        :this("concrete", "shingle")
    { }
    public House(string foundation, string roofType)
        :this(foundation, roofType, "red", 25)
        { }
    public House(string foundation, string roofType, string doorColor, int windowSize)
    {
        Foundation = foundation;
        RoofType = roofType;
        DoorColor = doorColor;
        WindowSize = windowSize;
    }

    public void DoorOpenClose()
    {
        Console.WriteLine($"My {DoorColor} door is open.");
    }
}