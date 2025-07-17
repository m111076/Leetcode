using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2255_Count_Prefixes_of_a_Given_String
    {
        //runtime 87%
        //time complexity O(n*m)
        //space complexity O(1)
        public int CountPrefixes(string[] words, string s)
        {
            var result = 0;

            foreach (var word in words)
            {
                if (s.StartsWith(word))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
