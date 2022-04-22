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
// Lesson12Example();
// Lesson11Example();
// Lesson10Example();
// Lesson9Example();
// Lesson8Example();
// Lesson7Example();
// Lesson6Example();
// Lesson5Example();
// Lesson4Example();
// Lesson3Example();
// Lesson2Example();
// Lesson1Example();
CondoExample();
// HouseUpdate();
// HouseExample(); 


//Lesson 12
void Lesson12Example()
{
    Fruit myFruit = new Fruit();
    myFruit.EatFruit();
    myFruit.EatFruit(5);

    Apple myApple = new Apple { };
    myApple.EatFruit();
}
// Lesson 11
void Lesson11Example()
{
    Square square = new Square();
    double total = square.CalculateInteriorAngle();
    Console.WriteLine(total);

    Triangle triangle = new Triangle();
    double total2 = triangle.CalculateInteriorAngle();
    Console.WriteLine(total2);
}
// HouseUpdate
void HouseUpdate()
{
    // Calling Default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();

    // Calling Coonstructor with 2 parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();

    // Calling Constructor with 4 parameters
    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.RoofType);
    myThird.DoorOpenClose();
}

// Lesson 10
void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10();

    // Using this to call another constructor
    Console.WriteLine(myLesson10.FirstName);
    Console.WriteLine(myLesson10.LastName);

    // Nomral property
    myLesson10.FirstName = "Paul";
    Console.WriteLine(myLesson10.FirstName);

    // Calling Auto Prtoperty
    // myLesson10.LastName = "smith"; // only works in Lesson10constructor
    Console.WriteLine(myLesson10.Id); // default value
    myLesson10.Id = 1500;
    Console.WriteLine(myLesson10.Id); // get 1500

    // Expression Body Property
    myLesson10.Address = "123 Main St.";
    Console.WriteLine(myLesson10.Address);

    // Second constructor
    Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 64119);
    Console.WriteLine(myOther10.Zipcode);
}
// Lesson 9
void Lesson9Example()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // Access Modifiers
    myLesson9.SampleInternal();
    myLesson9.SampleProtectedInternal();
    
}
//Lesson 8
void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // Calling constant directly
    Console.WriteLine(Lesson8.DaysPerMonth);

    // Calculate temperature
    Console.WriteLine(Lesson8Static.CelsiusToFahrenheit(45.6));

    // Static methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    Lesson8.CalculateDayCount();
    Console.WriteLine($"The calculation has been done {Lesson8.DayCount} times");

    // Static Lambda
    myLesson8.CalculateHoursV2();
}
//Lesson 7
void Lesson7Example()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // Readonly struct
    Student myStudent = new Student(10, "Roger");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);   
    Console.WriteLine(person.lastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);


}
//Lesson 6
void Lesson6Example()
{
    // default Constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");

    Console.WriteLine();

    // Constructor with 1 parameter
    Lesson6 myOthers = new Lesson6(22);

    // Constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value

    // Method Parameter Modifiers
    int able = 33, beta = 22, charlie;
    myLesson6.InExample(able);
    myLesson6.RedExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);

    Console.WriteLine();

    // Multi-cast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;

    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");
}
// Lesson 5 Expression & Pattern Matching
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();
    // Call method of myLEsson5
    // myLesson5.IsOperatorExample(34);

    Lesson5.Del handler = myLesson5.DelegateMethod;
    // handler("Hello CSharp");

    // func delegate
    Func<int, int> add = myLesson5.Sum;
    // Console.WriteLine($"func example = {add(23)}");

    //lambda Expression
    // myLesson5.LambdaSquare();
    // myLesson5.LambdaGreeting();

    // Switch Expressions
    string value1 = myLesson5.BasicSwitch("red");
    // Console.WriteLine(value1);
    string value2 = myLesson5.Favoritecolor("green");
    // Console.WriteLine(value2);

    // Relational Pattern
    // myLesson5.DrinkSize(33);
    myLesson5.TemeratureGuide(48.6);
    myLesson5.NumberChoice(3);
}
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

// Condo example/inheritance
void CondoExample()
{
    Condo myCondo = new Condo();
    myCondo.Maintenance();
    myCondo.DoorOpenClose();
    Console.WriteLine(myCondo.RoofType);
}
// House Example
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
// Exercise1();


void Exercise1()
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
// Exercise2();

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
// Exercise3();

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
// Exercise4();

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

// Exercise5();
void Exercise5()
{
    Exercise5 myExercise5 = new Exercise5();
    myExercise5.Question1();
    myExercise5.Question2("T");
    myExercise5.Question3(7);

}

// Exercise6();
void Exercise6()
{
    Exercise6 myExercise6 = new Exercise6("Jordan", 11);
    Exercise6 myShoe = new Exercise6("Nike", 11);
    Console.WriteLine(myShoe.shoeSize);
    Console.WriteLine(myShoe.shoeType);
    myShoe.shoeType = "Jordan";
    myShoe.shoeSize = 10;
    Exercise6.TryOn theNewShoe;
    theNewShoe = myExercise6.TryOnShoe;
    theNewShoe($"Trying a {myExercise6.shoeType} shoe");
}

// Exercise7();
void Exercise7()
{
    Employee myEmployee = new Employee(514, "Jeff");
    Console.WriteLine(myEmployee.EmployeeId);
    Console.WriteLine(myEmployee.EmployeeName);

    ExerciseBoat material = new ExerciseBoat("coal");
    // material.CargoShip();
    Console.WriteLine(material);
}

// Exercise8();
void Exercise8()
{
    Exercise8 myExercise8 = new Exercise8(2);
    myExercise8.Question1();
    Console.WriteLine(Exercise8static.Question2(45, 45));
}

Horse();
void Horse()
{
    Horse myHorse = new Horse();
    Console.WriteLine(myHorse.Hieght);
    Console.WriteLine(myHorse.Breed);
    Console.WriteLine(myHorse.LoadCapacity);

    Yak yak = new Yak(20);
    Console.WriteLine(yak.Hieght);
    Console.WriteLine(yak.Breed);
    Console.WriteLine(yak.LoadCapacity);
    Console.WriteLine(yak.Speed);

}

ExerciseBoat();
void ExerciseBoat()
{
    ExerciseBoat1 myBoat = new ExerciseBoat1();
    myBoat.BoatAnswer();

    TugBoat myTugBoat = new TugBoat(20);
    Console.WriteLine(myTugBoat.Speed);
    Console.WriteLine(myTugBoat.Size);
    Console.WriteLine(myTugBoat.LoadCapacity);
    Console.WriteLine(myTugBoat.Type);
}