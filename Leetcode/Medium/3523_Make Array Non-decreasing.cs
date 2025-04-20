using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3523_Make_Array_Non_decreasing
    {
        //runtime 78%
        //time complexity O(n)
        //space complexity O(1)
        public static int MaximumPossibleSize(int[] nums)
        {
            //var stack = new Stack<int>();
            var result = 0;
            var current = nums[0];

            foreach (var num in nums)
            {
                if (num >= current)
                {
                    result++;
                    current = num;
                }
                else
                {
                    current = Math.Max(current, num);
                }
                //if (stack.Count == 0 || num >= stack.Peek())
                //{
                //    stack.Push(num);
                //}
                //else
                //{
                //    var max = num;
                //    while (stack.Count > 0 && stack.Peek() > max)
                //    {
                //        max = Math.Max(max, stack.Pop());

                //    }
                //    stack.Push(max);
                //}
            }

            //return stack.Count;
            return result;
        }
    }
}
