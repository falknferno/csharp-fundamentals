﻿

namespace MyFirstApplication;


/*
  Contants and Static 
 */
internal class Lesson8
{
    // Constant Variables
    public const int Months = 12; // per year
    public const int Weeks = 52; // per year
    public const int Days = 365; // per year
    public const int Hours = 24; // per day

    public const double DaysPerMonth = (double)Days / (double)Months;

    public static int DayCount;
    private int _days;

    public Lesson8(int calDays)
    {
        _days = calDays;
    }

    public static int CalculateDayCount()
    {
        return ++DayCount;
    }

    public void CalculateHours()
    {
        int total = Hours * _days;
        Console.WriteLine($"The total hours for {_days} is {total}");
        CalculateDayCount();
    }

    public void CalculateHoursV2()
    {
        Func<int, int> totalHours = static value => Hours * value;
        Console.WriteLine($"Total version2 hours for {_days} is " +
            $"{totalHours(_days)}.");
    }


}
