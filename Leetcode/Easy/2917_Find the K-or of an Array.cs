using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2917_Find_the_K_or_of_an_Array
    {
        //runtime 60%
        //time complexity O(n)
        //space complexity O(1)
        public int FindKOr(int[] nums, int k)
        {
            var bitsCnt = new int[32];

            foreach (var num in nums)
            {
                var cnt = 0;
                var tmp = num;
                while (tmp > 0)
                {
                    if ((tmp & 1) == 1)
                    {
                        bitsCnt[cnt]++;
                    }
                    cnt++;
                    tmp >>= 1;
                }
            }

            var result = 0;

            for (var i = bitsCnt.Length - 1; i >= 0; i--)
            {
                var target = 0;
                if (bitsCnt[i] >= k)
                    target = 1;

                result = (result << 1) | target;
            }

            return result;
        }
    }
}
