using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += 1;
            }

            Console.WriteLine(sum);
        }
    }
}
