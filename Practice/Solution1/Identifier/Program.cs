using System;

namespace Identifier
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem uniqueItem = new UniqueItem(UniqueItem.Id);
            UniqueItem uniqueItem2 = new UniqueItem(UniqueItem.Id);
            UniqueItem uniqueItem3 = new UniqueItem(UniqueItem.Id);

            UniqueItem.Id = 10;

            UniqueItem uniqueItem4 = new UniqueItem(UniqueItem.Id);
            UniqueItem uniqueItem5 = new UniqueItem(UniqueItem.Id);
            UniqueItem uniqueItem6 = new UniqueItem(UniqueItem.Id);
        }
    }
}
