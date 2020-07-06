using System;
using System.Collections.Generic;
using System.Text;

namespace Identifier
{
    class UniqueItem
    {
        static int _id = 0;

        public static int Id
        {
            get => _id;
            set => _id = value;
        }

        static UniqueItem()
        {
            _id++;
        }
    }
}
