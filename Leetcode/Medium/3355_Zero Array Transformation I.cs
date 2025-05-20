using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3355_Zero_Array_Transformation_I
    {
        //runtime 50 
        //time complexity O(n+q)
        public bool IsZeroArray(int[] nums, int[][] queries)
        {
            var diff = new int[nums.Length];

            foreach (var q in queries)
            {
                diff[q[0]]++;
                if (q[1] + 1 < nums.Length)
                    diff[q[1] + 1]--;
            }

            var total = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                total += diff[i];
                if (total < nums[i])
                    return false;
            }

            return true;
        }
        //TLE 666
        //要用差分
        //time complexity O(n*q)
        //public bool IsZeroArray(int[] nums, int[][] queries)
        //{
        //    var tmp = new int[nums.Length];

        //    foreach (var q in queries)
        //    {
        //        for (var i = q[0]; i <= q[1]; i++)
        //        {
        //            tmp[i]++;
        //        }
        //    }

        //    for (var i = 0; i < nums.Length; i++)
        //    {
        //        if (tmp[i] < nums[i])
        //            return false;
        //    }

        //    return true;
        //}
    }
}
