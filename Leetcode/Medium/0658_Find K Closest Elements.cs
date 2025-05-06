using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _0658_Find_K_Closest_Elements
    {
        //runtime 92%
        //time complexity O(logn+k)
        //Binary Search
        public static IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var left = 0;
            var right = arr.Length - k;


            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (x - arr[mid] > arr[mid + k] - x)
                    left = mid + 1;
                else
                    right = mid;
            }

            var result = new List<int>();
            for (var i = 0; i < k; i++)
            {
                result.Add(arr[left + i]);
            }

            return result;
        }


        //runtime 27%
        //time complexity O(nlogm)
        //public static IList<int> FindClosestElements(int[] arr, int k, int x)
        //{
        //    var set = new int[arr.Length][];
        //    //O(n)
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        set[i] = new int[] { Math.Abs(arr[i] - x), i };
        //    }

        //    //Array.Sort(set, (a, b) => a[0] - b[0]);
        //    //O(n log n)
        //    set = set.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();

        //    var result = new List<int>();

        //    //O(k)
        //    for (int i = 0; i < k; i++)
        //    {
        //        result.Add(arr[set[i][1]]);
        //    }

        //    //O(k log k)
        //    result = result.OrderBy(x => x).ToList();

        //    return result;
        //}
    }
}
