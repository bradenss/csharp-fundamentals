using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication;

/*
 A record is a reference type that provides build-in functionality
for encapsulationg data
 */
internal record Person(string firstName, string lastName);

/*
A record is a value type with similar functionality as a record class.
*/
public record struct Resolution(int width, int height)
{
    public void CalculateRes()
    {
        Console.WriteLine(width + height);
    }
}
