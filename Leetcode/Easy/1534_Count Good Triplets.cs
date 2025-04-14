using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1534_Count_Good_Triplets
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            //runtime 72.3%
            //time complexity: O(n^3)
            //space complexity: O(1)
            var resut = 0;

            for (var i = 0; i < arr.Length - 2; i++)
            {
                for (var j = i + 1; j < arr.Length - 1; j++)
                {
                    for (var k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            resut++;
                    }
                }
            }

            return resut;
        }
    }
}
