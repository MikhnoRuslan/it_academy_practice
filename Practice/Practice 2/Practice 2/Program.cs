using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tack2MixedArray();
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
        }
    }
}
  
