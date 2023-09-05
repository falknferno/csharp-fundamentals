namespace MyFirstApplication.Exercises
{
    public class Exercise17
    {
        public void MyException()
        {
            int able = 96;
            int beta = 4;
            try
            {
                int answer = able / beta;
                Console.WriteLine("96 / 4 = 24");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"The the answer is not right, then {ex.Message} is 0");
            }
        }

        public void myHorse(Horse horse)
        {
            if (horse == null)
            {
                throw new NullReferenceException("The horse object is null");
            }
            else
            {
                Console.WriteLine(horse.HairColors);
            }
        }


    }
} // end class
