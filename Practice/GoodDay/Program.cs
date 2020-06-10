using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
            Greeting greeting = new Greeting();
            greeting.Print();
        }
    }

    class Constants
    {
        internal const byte Morning = 9;
        internal const byte Day = 12;
        internal const byte Evening = 15;
        internal const byte Night = 22;
    }

    class Greeting
    {
        internal void Print()
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            if (time.Hours > Constants.Morning && time.Hours < Constants.Evening)
                Console.WriteLine($"Good morning, guys");
            else if (time.Hours > Constants.Day && time.Hours < Constants.Evening)
                Console.WriteLine($"Good day, guys");
            else if (time.Hours > Constants.Evening && time.Hours < Constants.Night)
                Console.WriteLine($"Good evening, guys");
            else
                Console.WriteLine($"Good night, guys");
        }
    }
}
