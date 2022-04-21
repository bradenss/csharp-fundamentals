
namespace MyFirstApplication;

internal class Exercise3
{
    /*Write a method that takes 1 int argument and an int return type. Utilize
the modulus operator to complete this task. Assign the data values below
to their own variables. Use the Console WriteLine statement on the first 4
variables listed below and calculate the modulus with the passed in
argument parameter. Using the last variable below, calculate the modulus
with the passed in argument parameter and return it
    */
    public void Question1(int alpha)
    {
        int total = 15 % alpha;
        int total1 = 456 % alpha;
        int total2 = 23 % alpha;
        int total3 = 89 % alpha;
        Console.WriteLine(total);
        Console.WriteLine(total1);
        Console.WriteLine(total2);
        Console.WriteLine(total3);
    }

    /*Write a method that takes no arguments and a void return type. Utilizing
the math problem in this task, fill in any missing pieces to get the output.
10 + 32 * 12 / 3. Write a Console WriteLine to solve each output.
*/
    public void Question2()
    {
        int able = 10, beta = 32, charlie = 12, delta = 3;
        int Total = able + beta * charlie / delta;
        int Total1 = (able + beta) * charlie / delta;
        int Total2 = (able + (beta * charlie)) / delta;

        Console.WriteLine($"Answer A = {Total}, Answer B = {Total1}, Answer C = {Total2}");
    }

    /*Write a method that takes two short type arguments and a void return
type. Using the Compound Assignment operators below, use the first
argument parameter as the left operand to get the result. Print each one
using the Console WriteLine statement.*/
    public void Question3(int val1, int val2)
    {
        val1 += val2;
        Console.WriteLine(val1);

        val1 /= val2;
        Console.WriteLine(val1);

        val1 *= val2;
        Console.WriteLine(val1);

        val1 %= val2;
        Console.WriteLine(val1);
    }

    /*Write a method that takes two bool type arguments and a void return
type. Using Boolean Logical operators &, |, ^, and || to complete this task.
Use a Console WriteLine statement to calculate each result using the
operators. The second argument is the left operand. Use the below values
when testing your method. Using comments, provide your output results
inside the method after your statements.
    */

    public void Question4(bool arg, bool arg2)
    {
        // Part A False
        Console.WriteLine(arg & arg2);
        // Part B True
        Console.WriteLine(arg | arg2);
        // Part C True
        Console.WriteLine(arg ^ arg2);
        // Part D False True
        Console.WriteLine(4 > 24 || 4 < 24);
    }
}