using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3524_Find_X_Value_of_Array_I
    {
        public long[] ResultArray(int[] nums, int k)
        {
            //runtime 90%
            //time complexity O(n*k)
            //space complexity O(k)
            var result = new long[k];
            var dp = new long[k];

            foreach (var num in nums)
            {
                var dpTmp = new long[k];

                for (var i = 0; i < k; i++)
                {
                    var tmpVal = ((long)i * num) % k;
                    dpTmp[tmpVal] += dp[i];
                    result[tmpVal] += dp[i];
                }

                dp = dpTmp;
                dp[num % k]++;
                result[num % k]++;
            }

            return result;
            //TLE
            //var n = nums.Length;
            //var result = new long[k];

            //for (int i = 0; i < n; i++)
            //{
            //    long product = 1;
            //    for (int j = i; j < n; j++)
            //    {
            //        product = (product * nums[j]) % k;
            //        result[(int)product]++;
            //        if (product == 0)
            //        {
            //            result[(int)product] += n - j - 1;
            //            break;
            //        }
            //    }
            //}

            //return result;
        }
    }
}
