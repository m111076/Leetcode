using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0169_Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            //???????
            //Array.Sort(nums);
            //return nums[nums.Length / 2];

            //參考 摩爾投票法(Moore voting)
            //int candidate = nums[0];
            //int count = 1;

            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] == candidate)
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        count--;
            //        if (count == 0)
            //        {
            //            candidate = nums[i];
            //            count = 1;
            //        }
            //    }
            //}

            //return candidate;



            //Runtime 37% 爛死
            var numDis = nums.Distinct();
            var half = nums.Length / 2;
            var target = 0;

            foreach (int num in numDis)
            {
                var val = nums.Count(n => n == num);
                if (val > half)
                {
                    target = num;
                    break;
                }
            }
            return target;
        }
    }
}
