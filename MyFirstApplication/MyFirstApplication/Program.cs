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

// Lesson Examples
// HouseExample();

void HouseExample()
{
    House myHouse; new House();
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

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntergralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}

// Excercise1
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