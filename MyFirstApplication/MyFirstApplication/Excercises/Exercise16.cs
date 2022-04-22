

namespace MyFirstApplication;

internal class Exercise16
{
    /*
     Write a method that has no parameters and a no return type. Create a
List<T> of your Horse objects. When creating your list, utilize all the
constructors you created with your Horse class. Using a foreach loop, print
out the results of your collection using a Console WriteLine statement
     */
    public void Question1()
    {
        List<string> horseObjects = new List<string>();
        horseObjects.Add("Race");
        horseObjects.Add("Work");
        horseObjects.Add("Show");

        foreach (string type in horseObjects)
        {
            Console.WriteLine($"That type of horse is{type}");
        }
    }

    /*
     Write a method that has no parameters and no return type. Using only the
data you used when building your favorite movies from exercise 15, create
a Dictionary collection that takes an int key and string value. When adding
Dictionary elements, pick an int value as the key and use the favorite
movies data as the string. Using a foreach loop, print out the results of your
collection using a Console WriteLine statement.
     */
    public void FavoriteMovie()
    {
        Dictionary<int, string> openwith = new Dictionary<int, string>();
        openwith.Add(1, "Chocolate");
        openwith.Add(2, "Vanilla");
        openwith.Add(3, "Rainbow Sherbert");

        // to get a single calue, we use the TryGetValue method
        string flavor;
        if (openwith.TryGetValue(2, out flavor))
        {
            Console.WriteLine($"For key 2 we have {flavor}");
        }

        foreach (KeyValuePair<int, string> item in openwith)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}
