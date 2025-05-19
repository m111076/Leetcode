using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3024_Type_of_Triangle
    {
        public string TriangleType(int[] nums)
        {
            //runtime  12%
            //time complexity O(1)
            Array.Sort(nums);

            if (nums[0] + nums[1] <= nums[2])
                return "none";

            var set = new HashSet<int>();
            set.Add(nums[0]);
            set.Add(nums[1]);
            set.Add(nums[2]);

            if (set.Count == 1)
                return "equilateral";
            else if (set.Count == 2)
                return "isosceles";
            else
                return "scalene";
        }
    }
}
