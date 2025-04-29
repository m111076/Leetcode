using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2185_Counting_Words_With_a_Given_Prefix
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //函式使用
        public int PrefixCount(string[] words, string pref)
        {
            var restult = 0;

            foreach (var word in words)
            {
                if (word.StartsWith(pref))
                {
                    restult++;
                }
            }

            return restult;
        }
    }
}
