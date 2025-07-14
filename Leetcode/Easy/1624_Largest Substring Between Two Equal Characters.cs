using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1624_Largest_Substring_Between_Two_Equal_Characters
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            var charOccur = new List<int>[26];

            for (int i = 0; i < 26; i++)
            {
                charOccur[i] = new List<int>();
            }

            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'a';
                charOccur[index].Add(i);
            }

            var result = -1;

            for (int i = 0; i < 26; i++)
            {
                if (charOccur[i].Count > 1)
                {
                    var firstIndex = charOccur[i][0];
                    var lastIndex = charOccur[i][charOccur[i].Count - 1];
                    result = Math.Max(result, lastIndex - firstIndex - 1);
                }
            }

            return result;
        }
    }
}
