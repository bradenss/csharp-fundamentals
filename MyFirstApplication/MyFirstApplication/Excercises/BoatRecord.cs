
namespace MyFirstApplication;

internal record struct ExerciseBoat(string message)
{
    /*
Create a Record based on your Boat object from the Object Oriented
Programming lesson. In your record body, include the boat method that
you defined. This record can be in the same file as exercise 1. Just put the
code under it as seen in the lecture. Test your record to ensure it is working
correctly.
*/
    public void CargoShip()
    {
        Console.WriteLine($"Carries {message}.");
    }
}
