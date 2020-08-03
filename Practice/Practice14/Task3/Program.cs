using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            ConsoleKeyInfo key;
            List<Neighbor> neighbors = new List<Neighbor>();

            do
            {
                neighbors.Add(new Neighbor(AddFullName(), AddFlatNumber(), AddPhoneNumber()));
                Console.WriteLine($"Do you want to add more (Y/N)?");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key != ConsoleKey.N);

            var numFlat = AddFlatNumber();
            
            for (int i = 0; i < neighbors.Count; i++)
            {
                if (neighbors[i].FlatNumber.Equals(numFlat))
                    neighbors[i].ShowData();
            }
        }

        static string AddFullName()
        {
            Console.WriteLine($"Enter full name:");
            return Console.ReadLine();
        }

        static int AddFlatNumber()
        {
            Console.WriteLine($"Enter flat number");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string AddPhoneNumber()
        {
            Console.WriteLine($"Enter phone number:");
            return Console.ReadLine();
        }
    }
}
