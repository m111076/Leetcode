using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3442_Maximum_Difference_Between_Even_and_Odd_Frequency_I
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //紀錄後比大小
        public int MaxDifference(string s)
        {
            var c = new int[26];

            foreach (var ch in s)
            {
                c[ch - 'a']++;
            }

            var oddMax = int.MinValue;
            var evenMin = int.MaxValue;


            for (var i = 0; i < 26; i++)
            {
                if (c[i] == 0)
                    continue;

                if (c[i] % 2 == 0)
                {
                    evenMin = Math.Min(evenMin, c[i]);
                }
                else
                {
                    oddMax = Math.Max(oddMax, c[i]);
                }
            }

            return oddMax - evenMin;
        }
    }
}
