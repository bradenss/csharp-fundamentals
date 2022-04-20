using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// House myHouse = new House();
// myHouse.DoorOpenClose();

// The below statement calls a local function
// single line comment

/*
 multi-line comment
The below statement is a local funciton. Local functions 
are inside of members and are private y default. This means
They are specific to that memer and can only be called
inside that member.
 */

// Lesson Examples:
Lesson3Example();
// Lesson2Example()
// Lesson1Example()
// HouseExample(); 

// Lesson 3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 mylesson3 = new Lesson3();
    // mylesson3.BaasicCheckedOperator(14);
    // mylesson3.BaasicCheckedExample2();
    /*int alpha = 2147483647;
    int total = alpha + 10;
    Console.WriteLine(total);
    */
    /* -2147483639 this is the answer above since it went 
     past pos max it starts at neg max and goes back to 0.
    */
    //mylesson3.BasicUncheckedExample();
    // mylesson3.BasicMath();
    // mylesson3.BasicModulus(783);
    // mylesson3.BasicBooleanLogical(true, false);
    // mylesson3.BasicCompoundExample(12, 35, 9);
    // mylesson3.BasicRelationalExample("tom", "Tom");
    mylesson3.MyIncrDecrExample();
}
// Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualsExample("Hello World");
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.myEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();
}

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntergralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}

// This local function is for my first exercise lab.

// CSharpFunction();

void CSharpFunction()
{
    Console.WriteLine("This is my first sentence.");
    Console.WriteLine("I am new to Csharp.");
    Console.WriteLine("This CSharp course is cool.");
    Console.WriteLine("I am learning stuff every day.");
}


// Excercise1
Exercise1Answer();


void Exercise1Answer()
{
    Exercise1 myExercise = new Exercise1();
    // Question 1
    myExercise.IntergralNumbers();
    // Question 2
    myExercise.ConvertByteToInt();
    myExercise.ConvertShortToLong();
    myExercise.ConvertInttoFloat();
    // Question 3
    myExercise.ConvertDoubleToLong();
    myExercise.ConvertFloatToInt();
    myExercise.ConvertLongtoShort();
    // Question 4
    myExercise.DecimalMinMax();
    myExercise.LongMinMax();
    myExercise.UshortMinMax();
    myExercise.UIntMinMAx();
    myExercise.DecimalMinMax1();
}
// Excercise 2
void Exercise2()
{ 
    Exercise2 myExercise2 = new Exercise2();
    // Question 1
    myExercise2.MyTrim();
    myExercise2.MyLower();
    myExercise2.MyEquals
    int beta = myExercise2.MyStringLength();
    Console.WriteLine(beta);
    myExercise2.MyEquals();
    // Question 2
    myExercise2.MyChar();
    // Question 3
    Console.WriteLine(myExercise2.myJackandJillSong());
    // Question 4
    Console.WriteLine(myExercise2.MyName("Braden"));
    Console.WriteLine(myExercise2.MyName("LOTR"));
    Console.WriteLine(myExercise2.MyName("Speers"));
    Console.WriteLine(myExercise2.MyName("Mountain Dew"));
}

// Exercise 3
void Exercise3()
{
    // Question 1
    Exercise3 myExercise3 = new Exercise3();
    myExercise3.BasicModulus(15);
    myExercise3.BasicModulus2(456);
    myExercise3.BasicModulus2(23);
    myExercise3.BasicModulus3(89);
    myExercise3.BasicModulus3(245);
    // Question 2
    myExercise3.BasicMath();
    // Question 3
    myExercise3.Compound(15, 10);
    // Question 4
    myExercise3.Boolean(true, false);
}
