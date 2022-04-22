

namespace MyFirstApplication;

// Lesson 16 Collections
internal class Lesson16
{
    /*
     The List <T> is the same as an ArrayList, but we define out type in
    it declration as all items are of the same type.
     */
    public void MyListExample()
    {
        List<string> myStringList = new List<string>();
        myStringList.Add("Alpha");
        myStringList.Add("Bravo");
        myStringList.Add("Charlie");
        myStringList.Add("Delta");
        myStringList.Add("Echo");
        myStringList.Add("Foxtrot");

        // Gets or sets the total number of elements
        Console.WriteLine($"Capacity is {myStringList.Capacity}");
        Console.WriteLine($"Total count is {myStringList.Count}");

        // Bool if list constains?
        Console.WriteLine($"This list might contain {myStringList.Contains("Delta")}");

        // Insert and remove items
        myStringList.Insert(3, "Happy");
        myStringList.Remove("Happy");

        // Iterate through the elments
        foreach(string item in myStringList)
        {
            Console.WriteLine(item);
        }
    }

    /*
     This collection is based around key value pairs
     */
    public void MyDictionaryExample()
    {
        Dictionary<int, string> openwith = new Dictionary<int, string>();
        openwith.Add(10, "CSharp");
        openwith.Add(20, "Rocks");
        openwith.Add(30, "happy");
        openwith.Add(40, "Friday");

        // to get a single calue, we use the TryGetValue method
        string value;
        if (openwith.TryGetValue(20, out value))
        {
            Console.WriteLine($"For key 20 we have {value}");
        }

        foreach (KeyValuePair<int, string> item in openwith)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}
