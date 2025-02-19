using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _28_Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        public static int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; ++i)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
