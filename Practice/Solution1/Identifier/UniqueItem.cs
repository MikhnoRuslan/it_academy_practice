using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Identifier
{
    class UniqueItem
    {
        public static int Id { get; set; } = 0;

        public UniqueItem(int id)
        {
            Id = id;
            Id++;
            PrintId();
        }

        private static void PrintId()
        {
            Console.WriteLine(GetId());
        }

        private static string GetId()
        {
            return $"{Id}";
        }
    }
}
