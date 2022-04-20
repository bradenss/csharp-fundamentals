
namespace MyFirstApplication;

internal class Exercise1
{
    public long myShort;
    public float myFloat;
    public int myInt;
    public long myDouble;
    public int myFloat1;
    public short myLong;

    // Question 1
    public void IntergralNumbers()
    {
        // value of 35
        int value1 = 35; // decimal
        int value2 = 23; // not sure how to make the hexadecimal value, I just got 23?
        int value3 = 00100011; // binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    // Question 2 
    // Part A
    public void ConvertByteToInt()
    {
        int converted = (int)myInt;
        Console.WriteLine(converted);
    }
    // Part B
    public void ConvertShortToLong()
    {
        long converted = (long)myShort;
        Console.WriteLine(converted);
    }
    // Part C
    public void ConvertInttoFloat()
    {
        float converted = (float)myFloat;
        Console.WriteLine(converted);
    }
    // Question 3
    // Part A
    public void ConvertDoubleToLong()
    {
        long converted = (long)myDouble;
        Console.WriteLine(converted);
    }
    // Part B
    public void ConvertFloatToInt()
    {
        int converted = (int)myFloat1;
        Console.WriteLine(converted);
    }
    // Part C
    public void ConvertLongtoShort()
    {
        short converted = (short)myLong;
        Console.WriteLine(converted);
    }
    // Question 4
    // Part A
    decimal myDecimal = 123456.987M;

    public void DecimalMinMax()
    {
        Console.WriteLine(Decimal.MinValue);
        Console.WriteLine(Decimal.MaxValue);
    }
    // Part B
    long myLong1 = -9516248L;

    public void LongMinMax()
    {
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
    }
    // Part C
    ushort myUShort = 42;

    public void UshortMinMax()
    {
        Console.WriteLine(UInt16.MinValue);
        Console.WriteLine(UInt16.MaxValue);
    }
    // Part D 
    uint myUint = 988562486U;

    public void UIntMinMAx()
    {
        Console.WriteLine(UInt32.MinValue);
        Console.WriteLine(UInt32.MaxValue);
    }
    // Part E
    decimal myDecimal1 = -19733.14895M;

    public void DecimalMinMax1()
    {
        Console.WriteLine(Decimal.MinValue);
        Console.WriteLine(Decimal.MaxValue);
    }
}
