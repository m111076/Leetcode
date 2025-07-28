using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3618_Split_Array_by_Prime_Indices
    {
        public long SplitArray(int[] nums)
        {
            var IsPrime = new bool[nums.Length];
            Array.Fill(IsPrime, true);
            if (nums.Length > 0)
                IsPrime[0] = false;
            if (nums.Length > 1)
                IsPrime[1] = false;

            for (var i = 2; i * i < IsPrime.Length; i++)
            {
                if (IsPrime[i])
                {
                    for (var j = i * i; j < IsPrime.Length; j += i)
                    {
                        IsPrime[j] = false;
                    }
                }
            }

            var result = 0L;

            for (var i = 0; i < nums.Length; i++)
            {
                if (IsPrime[i])
                    result += nums[i];
                else
                    result -= nums[i];
            }

            return Math.Abs(result);
        }
    }
}
