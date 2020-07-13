using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    static class StringHelper
    {
        public static string CropString(this string str, string str2)
        {
            var newStr = string.Empty;
            for (int i = 0; i < str2.Length; i++)
            {
                if (i >= 5)
                    break;

                newStr += str2[i];
            }

            return $"{newStr}...";
        }
    }
}
