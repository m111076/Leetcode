using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1343_Number_of_Sub_arrays_of_Size_K_and_Average_Greater_than_or_Equal_to_Threshold
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //滑動視窗
        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            var t = k * threshold;
            var sum = 0;
            var result = 0;


            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (i < k - 1)
                    continue;
                if (sum >= t)
                    result++;
                sum -= arr[i - k + 1];
            }

            return result;
        }
    }
}
