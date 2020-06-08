using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine(DateTime.Now.TimeOfDay);
            Greeting greeting = new Greeting();
            greeting.Print(dateTime);
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
        internal void Print(DateTime dateTime)
        {
            if (dateTime.Hour > Constants.Morning && dateTime.Hour < 12)
                Console.WriteLine($"Good morning, guys");
            else if (dateTime.Hour > Constants.Day && dateTime.Hour < Constants.Evening)
                Console.WriteLine($"Good day, guys");
            else if (dateTime.Hour > Constants.Evening && dateTime.Hour < Constants.Night)
                Console.WriteLine($"Good evening, guys");
            else
                Console.WriteLine($"Good night, guys");
        }
    }
}
