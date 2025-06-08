using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2042_Check_if_Numbers_Are_Ascending_in_a_Sentence
    {
        //runtime 87%
        //time complexity O(n)
        //space complexity O(1)
        //分割字串 比較大小 TryParse
        public bool AreNumbersAscending(string s)
        {
            var tokens = s.Split(' ').ToList();
            int prev = -1;

            foreach (var token in tokens)
            {
                if (int.TryParse(token, out int target))
                {
                    if (target <= prev)
                    {
                        return false;
                    }
                    prev = target;
                }
            }

            return true;
        }
    }
}
