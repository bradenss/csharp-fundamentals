

namespace MyFirstApplication;

// Lesson 14 Arrays
internal class Lesson14
{
    public void SingleIntArray()
    {
        int[] intArray = { 2, 5, 34, 56, 28, 32 };
        foreach (int item in intArray)
        {
            Console.WriteLine(item);
        }
    }

    // Single Array of House
    public void SingleHouseArray()
    {
        House [] housearray = new House [3];
        housearray[0] = new House("concrete", "steel");
        housearray[1] = new House();
        housearray[2] = new House("dirt", "bamboo", "green", 33);

        foreach (House house in housearray)
        {
            Console.WriteLine($"House Roof in the collection in {house.RoofType}.");
        }
    }
    public void MultiIntArray()
    {
        int[,] sampleInt = new int[2, 2];
        sampleInt[0, 0] = 2;
        sampleInt[0, 1] = 4;
        sampleInt [1, 0] = 6;
        sampleInt[1, 1] = 8;

        foreach(int item in sampleInt)
        {
            Console.Write($"{item},");
        }
    }

    // Multi-dimensional string array using for loop.
    public void MultiStringArray()
    {
        string[,] myStringArray = { { "happy", "coding", "day", 
                "sad", "deployed", "bugs"} };
        for(int i = 0; i < myStringArray.GetLength(0); i++)
        {
            for(int k = 0; k < myStringArray.GetLength(1); k++)
            {
                Console.WriteLine(myStringArray[i, k]);
            }
        }
    }

    public void JaggedArraySample()
    {
        int[][] sampleArray = new int[3][];
        sampleArray[0] = new int[] { 2, 4 };
        sampleArray[1] = new int[] { 6, 8, 10 };
        sampleArray[2] = new int[] { 12, 14, 16, 18 };

        foreach(int[] items in sampleArray)
        {
            Console.WriteLine();
            foreach(int item in items)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
