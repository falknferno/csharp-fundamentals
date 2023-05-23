using DocumentFormat.OpenXml.InkML;
using MyFirstApplication;
using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment


/*
 Multi-line comment
The below statement is a local function. Local functions
are inside of members and are private by default.  This means
they are specific to that member and can only be called 
inside that member.
 */

// Lesson Examples
// HouseExample();
// Lesson1Example();
// Lesson2Example();
// Exercise1Example();
// Exercise2Example();
// Lesson3Example()

// Lesson3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckedExample2();
    // int alpha = 2147483647;
    // int total = alpha + 1;
    // Console.WriteLine(total);
    // -2147483639
}


// Exercise 2
void Exercise2Example()
{
    Exercise2 myExercise2 = new Exercise2();
    myExercise2.myTrimExample();
    int able = myExercise2.MyStringLength();
    Console.WriteLine(able);
    myExercise2.MyContainsExample("Hello World");
    myExercise2.MyExampleChar();
    myExercise2.MyEscapeExample();
    Console.WriteLine(myExercise2.MyEscapeExample());
    Console.WriteLine(myExercise2.MyInterpolationExample("Anthony", "The Matrix", "pizza rolls", "root beer"));
        
}

// Exercise 1
void Exercise1Example()
{
    Exercise1 myExercise1 = new Exercise1();
    myExercise1.IntegralExample();
    myExercise1.IntFromByte();
    myExercise1.LongFromShort();
    myExercise1.FloatFromInt();
    myExercise1.ConvertDoubleToLong();
    myExercise1.ConvertFloatToInt();
    myExercise1.ConvertLongToShort();
    myExercise1.Integrals();
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
    myLesson2.MyEscapeExample();
    Console.WriteLine(myLesson2.MyEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();
}

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();

}

