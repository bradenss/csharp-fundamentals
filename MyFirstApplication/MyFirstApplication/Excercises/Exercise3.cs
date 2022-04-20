
namespace MyFirstApplication;

internal class Exercise3
{
    //question 1

    // Part A
    public void BasicModulus(int alpha)
    {
        int total = 10 % alpha;
        Console.WriteLine(total);
    }

    // Part B
    public void BasicModulus1(int beta)
    {
        int total1 = 10 % beta;
        Console.WriteLine(total1);
    }
    // Part C
    public void BasicModulus2(int charlie)
    {
        int total2 = 10 % charlie;
        Console.WriteLine(total2);
    }
    // Part D
    public void BasicModulus3(int delta)
    {
        int total3 = 10 % delta;
        Console.WriteLine(total3);
    }
    // Part E

    public void BasicModulus4(int echo)
    {
        int total4 = 10 % echo;
        Console.WriteLine(+50);
    }

    // Question 2
    public void BasicMath()
    {
        int able = 10, beta = 32, charlie = 12, delta = 3;
        int Total = able + beta * charlie / delta;
        int Total1 = (able + beta) * charlie / delta;
        int Total2 = (able + (beta * charlie)) / delta;

        Console.WriteLine($"Answer A = {Total}, Answer B = {Total1}, Answer C = {Total2}");
    }

    // Question 3
    public void Compound(int val1, int val2)
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

    // Question 4
    public void Boolean(bool arg, bool arg2)
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