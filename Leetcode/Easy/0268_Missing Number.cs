using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0268_Missing_Number
    {
        public int MissingNumber(int[] nums)
        {
            //rumtime 100%
            //求總和 之後一個一個減 T:O(N)
            var length = nums.Length;
            var result = (1 + length) * length / 2;

            foreach (var num in nums)
            {
                result -= num;
            }

            return result;
        }
    }
}
