using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal static class _1399_Count_Largest_Group
    {
        //runtime 76%
        //time complexity O(n)
        //space complexity O(n)
        public static int CountLargestGroup(int n)
        {
            var tmp = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                var sum = 0;
                var num = i;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                tmp[sum]++;
            }

            var target = tmp.Max();
            var result = 0;

            foreach (var item in tmp)
            {
                if (item == target)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
