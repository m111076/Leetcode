using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3375_Minimum_Operations_to_Make_Array_Values_Equal_to_K
    {
        public int MinOperations(int[] nums, int k)
        {
            //runtime 91%
            //time complexity O(nlogm)
            //space complexity O(n)
            var set = new PriorityQueue<int, int>();
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                    set.Enqueue(nums[i], nums[i]);
                }
            }

            var target = set.Dequeue();

            if (target < k)
                return -1;
            else if (target == k)
                return dict.Count - 1;
            else
                return dict.Count;


            //runtime 44%
            //time complexity O(n+mlogm)
            //space complexity O(n)
            //var target = nums.Distinct().ToArray();
            //Array.Sort(target);

            //if (target[0] < k)
            //    return -1;
            //else if (target[0] == k)
            //    return target.Length - 1;
            //else
            //    return target.Length;
        }

    }
}
