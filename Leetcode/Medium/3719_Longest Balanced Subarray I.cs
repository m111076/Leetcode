using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3719_Longest_Balanced_Subarray_I
    {
        public int LongestBalanced(int[] nums)
        {
            var even = new int[100001];
            var odd = new int[100001];
            var cnt = nums.Length;
            var flag = 0;
            var result = 0;

            for (var i = 0; i < cnt; i++)
            {
                flag++;
                int evenCnt = 0, oddCnt = 0;
                for (var j = i; j < cnt; j++)
                {
                    var target = nums[j];
                    if (target % 2 == 0)
                    {
                        if (even[target] != flag)
                        {
                            even[target] = flag;
                            evenCnt++;
                        }
                    }
                    else
                    {
                        if (odd[target] != flag)
                        {
                            odd[target] = flag;
                            oddCnt++;
                        }
                    }
                    if (evenCnt == oddCnt)
                    {
                        result = Math.Max(result, j - i + 1);
                    }
                }
            }

            return result;
        }
    }
}
