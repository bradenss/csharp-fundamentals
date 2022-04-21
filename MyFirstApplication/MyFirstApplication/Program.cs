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
Lesson4Example();
// Lesson3Example();
// Lesson2Example()
// Lesson1Example()
// HouseExample(); 

// Lesson 4 Control Flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(12);
    // myLesson4.BasicIfElseStatement(15);
    // myLesson4.BasicifElseChainStatement(10);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(25));
    // myLesson4.BasicSwitchStatement(5);
    // myLesson4.BasicWhileStatment();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatement();
    myLesson4.BasicJumpStatement();
}
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
    // mylesson3.MyIncrDecrExample();
}
// Lesson 2 Strings

Lesson2Example();

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
Lesson1Example();

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
    /*Console.WriteLine("This is my first sentence.");
    Console.WriteLine("I am new to Csharp.");
    Console.WriteLine("This CSharp course is cool.");
    Console.WriteLine("I am learning stuff every day.");*/
}


// Excercise1
Exercise1Answer();


void Exercise1Answer()
{
    Exercise1 myExercise = new Exercise1();
    // Question 1
    myExercise.Question1();
    // Question 2
    myExercise.Question2(10);
    myExercise.Question2b(10);
    myExercise.Question2c(10);
    // Question 3
    myExercise.Question3(10);
    myExercise.Question3b(10);
    myExercise.Question3c(10);
    // Question 4
    myExercise.Question4(123456.987M);
    myExercise.Question4b(-9516248L);
    myExercise.Question4c(42);
    myExercise.Question4d(988562486U);
    myExercise.Question4e(-19733.14895M);
    ;
}
Exercise2();

// Excercise 2
void Exercise2()
{ 
    Exercise2 myExercise2 = new Exercise2();
    // Question 1
    myExercise2.Question1( "EXERCISE two lab ");
    // Question 2
    myExercise2.Question2();
    // Question 3
    Console.WriteLine(myExercise2.Question3());
    // Question 4
    Console.WriteLine(myExercise2.Question4("Braden"));
    Console.WriteLine(myExercise2.Question4b("LOTR"));
    Console.WriteLine(myExercise2.Question4c("Speers"));
    Console.WriteLine(myExercise2.Question4d("Mountain Dew"));
}
Exercise3();

// Exercise 3
void Exercise3()
{
    // Question 1
    Exercise3 myExercise3 = new Exercise3();
    myExercise3.Question1(15);
    int alpha = 245;
    int total = alpha % 10;
    Console.WriteLine(total);
    // Question 2
    myExercise3.Question2();
    // Question 3
    myExercise3.Question3(15, 10);
    // Question 4
    myExercise3.Question4(true, false);
}
Exercise4();

// Excercise 4
void Exercise4()
{
    // Question 1
    Exercise4 myExercise4 = new Exercise4();
    myExercise4.Question1(10);
    // Question 2
    myExercise4.Question2("E");
    // Question3
    myExercise4.Question3();
}
