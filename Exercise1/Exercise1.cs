

namespace Exercises
{
    internal class Exercise1
    {

        public void IntegralExample()
        {
            int value1 = 35;
            int value2 = 0x23;
            int value3 = 0b100011;
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

        }

        // Implicit Conversions


        byte myByte = 88;


        public void IntFromByte()
        {
            int someValue = myByte;
            Console.WriteLine(someValue);
        }

        short myshort = 388;

        public void LongFromShort()
        {

            long someValue = myshort;
            Console.WriteLine(someValue);
        }

        int myInt = 3523;

        public void FloatFromIn()
        {

            float someValue = myInt;
            Console.WriteLine(someValue);
        }

        // Explicit Conversions

        double mydouble = 45.21D;

        public void ConvertDoubleToLong()
        {
            long converted = (long)mydouble;
            Console.WriteLine(converted);
        }

        float myfloat = 656.86F;

        public void ConvertFloatToInt()
        {
            int converted = (int)myfloat;
            Console.WriteLine(converted);
        }
        long mylong = 65L;

        public void ConvertLongToShort()
        {
            short converted = (short)mylong;
            Console.WriteLine(converted);
        }

        // Digit Seperator

        public void Integrals()
        {
            long alpha = (long)123_456.987;
            int number = -9_516_248;
            ushort beta = 3_500;
            ulong delta = 988_562_486;
            short value = (short)-19_733.14895;
            Console.WriteLine(alpha);
            Console.WriteLine(number);
            Console.WriteLine(beta);
            Console.WriteLine(delta);
            Console.WriteLine(value);
        }
    }
}
