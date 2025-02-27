using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1524_Number_of_Sub_arrays_With_Odd_Sum
    {
        public int NumOfSubarrays(int[] arr)
        {
            //runtime 100%
            //只需紀錄奇偶的數量 數值不重要
            long mod = 1000000007;
            var sum = 0;
            long odd = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                odd += sum & 1;
            }

            long even = arr.Length - odd;

            return (int)((even * odd + odd) % mod);

            //runtime 42%
            //long mod = 1000000007;
            //var addArr = new long[arr.Length + 1];
            //long even = 0;
            //long odd = 0;

            //for (var i = 0; i < arr.Length; i++)
            //{
            //    addArr[i + 1] = addArr[i] + arr[i];
            //    if ((addArr[i + 1] & 1) == 0)
            //        even++;
            //    else
            //        odd++;
            //}
            //return (int)((even * odd + odd) % mod);
        }
    }
}
