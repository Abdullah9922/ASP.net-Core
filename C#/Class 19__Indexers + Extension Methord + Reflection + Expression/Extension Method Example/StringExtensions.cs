using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Method_Example
{
    public static class StringExtensions
    {
        public static string ReverseText(this string text) // data type ar age this
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }
    }
}
