using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0136_Single_Number
    {
        public int SingleNumber(int[] nums)
        {
            int ret = 0;
            foreach (var num in nums)
            {
                //互斥運算 位元運算較快
                ret ^= num;
            }
            return ret;

            //runtime 45%
            //var apperNums = new Dictionary<int, int>();

            //foreach (var num in nums)
            //{
            //    if (apperNums.ContainsKey(num))
            //        apperNums.Remove(num);
            //    else
            //        apperNums.Add(num, num);
            //}
            //return apperNums.First().Key;
        }
    }
}
