

namespace MyFirstApplication;

/*
 Static class must have static methods as you cannot use instance methods.
 */
internal static class Lesson8Static
{
    public static double CelciusToFahrenheit(double celcius)
    {
        return (celcius * 9 / 5) + 32;
    }

    public static double FahrenheitToCelcius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
