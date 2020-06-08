using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

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

    class Greeting
    {
        private const byte Morning = 9;
        private const byte Day = 12;
        private const byte Evening = 15;
        private const byte Night = 22;
        internal void Print(DateTime dateTime)
        {
            if (dateTime.Hour > Morning && dateTime.Hour < 12)
                Console.WriteLine($"Good morning, guys");
            else if (dateTime.Hour > Day && dateTime.Hour < Evening)
                Console.WriteLine($"Good day, guys");
            else if (dateTime.Hour > Evening && dateTime.Hour < Night)
                Console.WriteLine($"Good evening, guys");
            else
                Console.WriteLine($"Good night, guys");
        }
    }
}
