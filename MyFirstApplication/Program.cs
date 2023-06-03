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
// Exercises2Example();
// Lesson3Example();
// Exercise3Example();
// Lesson4Example();
Exercise4Example();

void Exercise4Example()
{
    Exercise4 myExercise4 = new Exercise4();
    // myExercise4.IfElse(16, 38);
    // Console.WriteLine(myExercise4.GradeCheck('G'));
    myExercise4.Divisor();
}



// Lesson 4 Control Flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(11);
    // myLesson4.BasicIfElseStatement(12);
    // myLesson4.BasicIfElseChainStatement(5);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(35));
    // myLesson4.BasicSwitchStatement(3);
    // myLesson4.BasicWhileStatment();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatement();
    // myLesson4.BasicJumpStatement();
}

void Exercise3Example()
{
     // Exercise3 myExercise3 = new Exercise3();
     // myExercise3.Arithmetic();
     // myExercise3.Modulus(542);
     // myExercise3.Compound(10, 32, 12, 3, 30, 37);
}


// Lesson3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckedExample2();
    // myLesson3.BasicUncheckedExample();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.BasicBooleanLogical(true, false);
    // myLesson3.BasicCompoundExample(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tim");
    // myLesson3.MyIncrDecrExample();
    
}


// Exercise 2
void Exercises2Example()
{
    Exercises2 myExercise2 = new Exercises2();
    // myExercise2.myTrimExample();
    // int able = myExercise2.MyStringLength();
    // Console.WriteLine(able);
    // myExercise2.MyContainsExample("Hello World");
    // myExercise2.MyExampleChar();
    // myExercise2.MyEscapeExample();
    // Console.WriteLine(myExercise2.MyEscapeExample());
    // Console.WriteLine(myExercise2.MyInterpolationExample("Anthony", "The Matrix", "pizza rolls", "root beer"));

}

// Exercise 1
void Exercise1Example()
{
    Exercise1 myExercise1 = new Exercise1();
    // myExercise1.IntegralExample();
    // myExercise1.IntFromByte();
    // myExercise1.LongFromShort();
    // myExercise1.FloatFromInt();
    // myExercise1.ConvertDoubleToLong();
    // myExercise1.ConvertFloatToInt();
    // myExercise1.ConvertLongToShort();
    // myExercise1.Integrals();
}

// Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    // myLesson2.MyTrimExample();
    // int able = myLesson2.MyStringLength();
    // Console.WriteLine(able);
    // myLesson2.MyEqualsExample("Hello World");
    // myLesson2.MyExampleChar();
    // myLesson2.MyEscapeExample();
    // Console.WriteLine(myLesson2.MyEscapeExample());
    // myLesson2.MyJoinedStrings("CSharp", "Rules");
    // Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    // myLesson2.MyOtherInterpolation();
}

void HouseExample()
{
    House myHouse = new House();
    // myHouse.DoorOpenClose();
}

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    // myLesson.IntMinMax();
    // myLesson.IntegralExample();
    // myLesson.ConvertFloatToInt();
    // myLesson.LongFromInt();

 }

