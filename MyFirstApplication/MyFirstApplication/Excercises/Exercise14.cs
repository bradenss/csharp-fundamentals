

namespace MyFirstApplication;

internal class Exercise14
{
    /*
     Write a method with no parameters and no return type. Write a single
dimensional string array of ice cream flavors. Using a foreach loop in your
method, print out the results of your array using a Console WriteLine
statement.
     */
    public void Question1()
    {
        string[] flavors = { "Cocolate", "Vanilla", "Rainbow Sharbert",};
        foreach (string flavor in flavors)
        {
            Console.WriteLine(flavor);
        }
    }
    /*
     Write a method with no parameters and no return type. Write a twodimensional array using the int data type. Using the link below, fill in each
dimension with the KC Chiefs Regular season scores. The first dimension
will be the home team, while the second dimension will be the away team.
Using a foreach loop, print out the results of your array using a Console
WriteLine statement. To determine which team is home and away, the
website includes the link to the box score. The link label shows both teams.
The first team in the label is the away team.
a. https://www.footballdb.com/teams/nfl/kansas-citychiefs/results/2020
     */
    public void ChiefsScore()
    {
        int[,] Chiefs = { { 22, 38, 9 } };
        int[,] OHNYFL = { { 17, 24, 31 } };
        for (int i = 0; i < Chiefs.GetLength(0); i++)
        {
            for (int k = 0; k < OHNYFL.GetLength(1); k++)
            {
                Console.WriteLine(Chiefs[i, k]);
            }
        }
    }
}
