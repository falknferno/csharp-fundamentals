
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
// Lesson3Example();
// Exercise3Example();
// Lesson4Example();
// Exercise4Example();
// Lesson5Example();
// Exercise5Example();
// Lesson6Example();
// Lesson7Example();
Exercise7Example();
// Lesson8Example();
// Exercise8Example();
// Lesson9Example();
// Lesson10Example();
// HouseUpdated();
// HorseExample();
// BoatExample();


void BoatExample()
{
    BoatExercise myBoatExercise = new BoatExercise();
    Console.WriteLine(myBoatExercise._boatType.ToString("Speed boat"));
    Console.WriteLine(myBoatExercise._travels.ToString("Fast over water"));
    Console.WriteLine(myBoatExercise._boatName.ToString("Falcon"));
}


void HorseExample()
{
    Horse myHorse = new Horse();
    Console.WriteLine(myHorse.Breed);
    Console.WriteLine(myHorse.MoveType);
    Console.WriteLine(myHorse.HairColors);

    Console.WriteLine();

    Horse mySecond = new Horse("Mustang", "trots");
    Console.WriteLine(mySecond.Breed);
    Console.WriteLine(mySecond.MoveType);
}

void HouseUpdated()
{
    // Calling the Default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();

    // Calling constructor with 2 parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();

    // Calling constructor with 4 parameters
    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.Foundation);
    myThird.DoorOpenClose();
}


void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10(); // default constructor
    // Normal Property
    myLesson10.Firstname = "Paul"; // value of Paul to property of FirstName, then call it
    Console.WriteLine(myLesson10.Firstname);

    // calling auto 
    // myLesson10.LastName = "Smith"; // only works in Lesson10 constructor
    Console.WriteLine(myLesson10.Id); // default value
    myLesson10.Id = 1500;
    Console.WriteLine(myLesson10.Id); // get 1500

    // Expression body property
    myLesson10.Address = "123 Main St.";
    Console.WriteLine(myLesson10.Address);

    // 2nd Constructor
    Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 64119);
    Console.WriteLine(myOther10.Zipcode);
}

void Lesson9Example()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // Access modifiers
    myLesson9.SampleInternal();
    myLesson9.SampleProtectedInternal();
}

void Exercise8Example()
{
    Exercise8 myExercise8 = new Exercise8(12);
    Console.WriteLine(Exercise8.InchesPerFoot);
    Exercise8.InchCount = 2;
    myExercise8.CalculateInches();
    Exercise8.CalculateInchCount();
    Console.WriteLine($"The calculation has been done {Exercise8.InchCount} times");

    // Exercise8Stat.RectangleAndSquare();
}

void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // Calling constant directly
    Console.WriteLine(Lesson8.DaysPerMonth);

    // Calculate temperature
    Console.WriteLine(Lesson8Static.CelciusToFahrenheit(45.6));

    // Static Methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours(); 
    Lesson8.CalculateDayCount(); // is added to DayCount = 10...to make 12 when ran
    Console.WriteLine($"The calculation has been done {Lesson8.DayCount} times");

    // Static Lambda
    myLesson8.CalculateHoursV2();
}

void Exercise7Example()
{
    // Employee myEmployee = new Employee(10,"Tony");
    // Console.WriteLine(myEmployee.Id);
    // Console.WriteLine(myEmployee);

    // Record
    //Boat boat = new Boat("Speed Boat", "Fast over water", "Falcon");
    //Console.WriteLine(boat.boatType);
    //Console.WriteLine(boat.travels);
    //Console.WriteLine(boat.boatName);
    
    
}


void Lesson7Example()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    // Console.WriteLine(myLocation);

    // Readonly Struct
    Student myStudent = new Student(10, "Tony");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.lastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1800);
    res.CalculateRes();
    Console.WriteLine(res);

}

void Exercise6Example()
{

     Exercise6 myExercise6 = new Exercise6("Nike", 12);
     Exercise6.TryOn theShoe = myExercise6.TryOnShoe;
     theShoe($"I tried on a {myExercise6.ShoeType} shoe that was size {myExercise6.ShoeSize}");
  
}


void Lesson6Example()

{
    // Default Constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");

    // Console.WriteLine();    used as a space between the delegate above and the 
                                // the stuff that prints out below 
                                

    // Constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // Constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7); 
    Console.WriteLine(myHats.HatSize);  // getting value
    myHats.HatSize = 6; // setting value

    // Method Parameter Modifiers
    int able = 33, beta = 22, charlie;

    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);

    // Console.WriteLine();

    // Mult-cast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;

    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");



}

void Exercise5Example()
{
    Exercise5 myExercise5 = new Exercise5();
    int something = myExercise5.OhmsLaw(24, 10);
    Console.WriteLine(something);
    Console.WriteLine(myExercise5.Grades('B'));
    myExercise5.PopcornSize(70);
}
    

// Lesson 5 Expressions & Pattern Matching
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();
    myLesson5.IsOperatorExample(34);
    
    Lesson5.Del handler = myLesson5.DelegateMethod;
    handler("Hello Csharp");

    // Func Delegate
    Func<int, int> add = myLesson5.Sum;
    Console.WriteLine($"func example = {add(23)}");

    // Lambda Expression
    myLesson5.LambdaSquare();
    myLesson5.LambdaGreeting();

    // Switch Expression
    string value1 = myLesson5.BasicSwitch("red");
    Console.WriteLine(value1);
    string value2 = myLesson5.FavoriteColor("green");
    Console.WriteLine(value2);

    // Relational Pattern
    myLesson5.DrinkSize(33);

    // Logical Patterns
    myLesson5.TemperatureGuide(48.6);
    myLesson5.NumberChoice(3);


}


void Exercise4Example()
{
    Exercise4 myExercise4 = new Exercise4();
    myExercise4.IfElse(16, 38);
    Console.WriteLine(myExercise4.GradeCheck('G'));
    myExercise4.Divisor();
}



// Lesson 4 Control Flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    myLesson4.BasicIfStatement(11);
    myLesson4.BasicIfElseStatement(12);
    myLesson4.BasicIfElseChainStatement(5);
    myLesson4.BasicAndOrCondition(20, 20);
    Console.WriteLine(myLesson4.BasicTernaryExample(35));
    myLesson4.BasicSwitchStatement(3);
    myLesson4.BasicWhileStatment();
    myLesson4.BasicDoStatement();
    myLesson4.BasicForStatement();
    myLesson4.BasicForeachStatement();
    myLesson4.BasicJumpStatement();

}

void Exercise3Example()
{
    Exercise3 myExercise3 = new Exercise3();
    myExercise3.Arithmetic();
    myExercise3.Modulus(542);
    myExercise3.Compound(10, 32, 12, 3, 30, 37);
}


// Lesson3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    myLesson3.BasicCheckedOperator(14);
    myLesson3.BasicCheckedExample2();
    myLesson3.BasicUncheckedExample();
    myLesson3.BasicMath();
    myLesson3.BasicModulus(783);
    myLesson3.BasicBooleanLogical(true, false);
    myLesson3.BasicCompoundExample(12, 35, 9);
    myLesson3.BasicRelationalExample("Tom", "Tim");
    myLesson3.MyIncrDecrExample();

}


// Exercise 2
void Exercise2Example()
{
    Exercise2 myExercise2 = new Exercise2();
    myExercise2.myTrim();
    int able = myExercise2.MyStringLength();
    Console.WriteLine(able);
    myExercise2.MyContains("Hello World");
    myExercise2.MyChar();
    myExercise2.MyEscape();
    Console.WriteLine(myExercise2.MyEscape());
    Console.WriteLine(myExercise2.MyInterpolation("Anthony", "The Matrix", "pizza rolls", "root beer"));

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
    // myLesson2.MyJoinedStrings("CSharp", "Rules");
    // Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    // myLesson2.MyOtherInterpolation();
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

