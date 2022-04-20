
namespace MyFirstApplication;

internal class Exercise4
{
    //Question 1
    public void IfElseStatement(int beta)
    {
        if (beta >= 12)
        {
            Console.WriteLine($"{beta} is equal with the statement.");
        }
        else
        {
            Console.WriteLine($"{beta} was greater than the statment.");
        }
    }
    // Question 2
    public void ForeachStatement()
    {
        foreach (char E in "Description")
        {
            Console.WriteLine($"Excellent = {E}");
        }
        foreach (char V in "Description")
        {
            Console.WriteLine($"Very Good = {V}");
        }
        foreach (char G in "Description")
        {
            Console.WriteLine($"Good = {G}");
        }
        foreach (char A in "Description")
        {
            Console.WriteLine($"Average = {A}");
        }
        foreach (char F in "Description")
        {
            Console.WriteLine($"Fail = {F}");
        }
        foreach (char Else in "Description")
        {
            Console.WriteLine($"Not a valid grade = {Else}");
        }
    }
    public void JumpStatement()
    {
        for (int x = 0; x < 30; x++)
        {
            if (x == 0)
            {
                Console.WriteLine($"This {x} is 0.");
                continue;
            }
            if (x %= 3)
            {
                Console.WriteLine($"This should should the numbers divisible by 3 {x}");
                break;
            }
            Console.WriteLine($"Number = {x}");
        }
