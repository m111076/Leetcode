using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2900_Longest_Unequal_Adjacent_Groups_Subsequence_I
    {
        //runtime 100%
        //time complexity O(n)
        public IList<string> GetLongestSubsequence(string[] words, int[] groups)
        {
            var result = new List<string>();
            var pre = -1;

            for (int i = 0; i < words.Length; i++)
            {
                if (groups[i] != pre)
                {
                    result.Add(words[i]);
                    pre = groups[i];
                }
            }

            return result;
        }
    }
}
