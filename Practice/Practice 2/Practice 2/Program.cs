using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tack2MixedArray();
            Task3();
            Console.WriteLine();
            Task4();
        }

        static void Tack1EmptyArray()
        {
            int[] myArray = new int[] { }; 
        }

        static void Tack2MixedArray()
        {
            int firstValue = 32;
            char secondValue = 'A';
            string thirdValue = "Hello";
            Object[] mixedArray = new Object[3];
            mixedArray[0] = (int) firstValue;
            mixedArray[1] = (char) secondValue;
            mixedArray[2] = (string) thirdValue;
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine(mixedArray[i] + " ");
            }

            int sumForFirstValue = 10;
            string sumForThirdValue = ", guys!";

            for (int i = 0; i < mixedArray.Length; i++)
            {
                if (i == 0)
                {
                    mixedArray[i] = (int) mixedArray[i] + sumForFirstValue;
                }

                if (i == 2)
                {
                    mixedArray[i] = (string) mixedArray[i] + sumForThirdValue;
                }

                Console.WriteLine(mixedArray[i] + " ");
            }
        }

        static void Task3()
        {
            int rez = 0;
            int[] myArray = new int[13];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 100);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i] + " ");
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > rez)
                    rez = myArray[i];
            }

            Console.WriteLine($"Max = {rez}");
        }

        static void Task4()
        {
            short firstValue = 5;
            Object obj = firstValue;
            obj = (sbyte) firstValue;
            sbyte secondValue = (sbyte)obj;
            Console.WriteLine($"{obj} {secondValue.GetType()}");
        }
    }
}