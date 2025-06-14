using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0128_Longest_Consecutive_Sequence
    {
        //runtime 33%
        //time complexity O(n)
        //space complexity O(n)
        //查表O(1)
        //只從左側沒有連續的開始檢查
        //while那邊最多就跑N次
        public int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>();

            foreach (var i in nums)
            {
                set.Add(i);
            }

            var result = 0;

            foreach (var i in set)
            {
                var tmp = 0;

                if (!set.Contains(i - 1))
                {
                    var target = i;
                    while (set.Contains(target))
                    {
                        tmp++;
                        target++;
                    }

                    result = Math.Max(result, tmp);
                }
            }

            return result;
        }
    }
}
