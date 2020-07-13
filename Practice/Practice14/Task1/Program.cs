using System;

namespace Task1
{
    class Program
    {
        private const int SizeOfArray = 100;
        static void Main(string[] args)
        {
            var rectangle = new Rectangle[SizeOfArray];
            Random random = new Random();
            for (int i = 0; i < rectangle.Length; i++)
            {
                rectangle[i].Height = random.Next(1, 10);
                rectangle[i].Width = random.Next(1, 10);
            }

            for (int i = 0; i < rectangle.Length; i++)
            {
                rectangle[i].ShowRectangle();
            }

            Console.WriteLine();
            Console.WriteLine();
            int count = 0;

            for (int i = 0; i < rectangle.Length; i++)
            {
                if (rectangle[i].Equals(rectangle[0]))
                {
                    rectangle[i].ShowRectangle();
                    count++;
                }
            }
        }
    }
}
