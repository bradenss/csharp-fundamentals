using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// House myHouse = new House();
// myHouse.DoorOpenClose();

// The below statement calls a local function
// single line comment
HouseExample();

/*
 multi-line comment
The below statement is a local funciton. Local functions 
are inside of members and are private y default. This means
They are specific to that memer and can only be called
inside that member.
 */

void HouseExample()
{
    House myHouse; new House();
    myHouse.DoorOpenClose();
}

// This local function is for my first exercise lab.

CSharpFunction();

void CSharpFunction()
{
    Console.WriteLine("This is my first sentence.");
    Console.WriteLine("I am new to Csharp.");
    Console.WriteLine("This CSharp course is cool.");
    Console.WriteLine("I am learning stuff every day.");
}
