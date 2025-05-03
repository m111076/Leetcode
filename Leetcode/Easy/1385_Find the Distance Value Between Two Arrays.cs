using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1385_Find_the_Distance_Value_Between_Two_Arrays
    {
        //runtime 61%
        //time complexity O(nlogn+mlogn)
        //space complexity O(1)
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            Array.Sort(arr2);
            var result = 0;

            foreach (var i in arr1)
            {
                if (Check(arr2, i, d))
                    result++;
            }

            return result;

        }

        private bool Check(int[] arr2, int arr1, int d)
        {
            var left = 0;
            var right = arr2.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Math.Abs(arr1 - arr2[mid]) <= d)
                    return false;
                else if (arr2[mid] < arr1)
                    left = mid + 1;
                else
                    right = mid;
            }

            return true;
        }
    }
}
