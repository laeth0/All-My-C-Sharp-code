using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAdvancedC_
{
    internal static class ExtentionMethods
    {
        public static string Truncate(this string str, int MaxLength)
        {
            if (str.Length > MaxLength)
            {
                return str.Substring(0, MaxLength);
            }
            return str;
        }

        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
