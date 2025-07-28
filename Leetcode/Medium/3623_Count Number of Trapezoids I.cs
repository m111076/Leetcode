using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3623_Count_Number_of_Trapezoids_I
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        public int CountTrapezoids(int[][] points)
        {
            var mod = 1000000007;
            var xDict = new Dictionary<int, List<int>>();

            foreach (var point in points)
            {
                if (!xDict.ContainsKey(point[1]))
                {
                    xDict[point[1]] = new List<int>();
                }
                xDict[point[1]].Add(point[0]);
            }

            var pre = 0L;
            var result = 0L;

            foreach (var value in xDict.Values)
            {
                var cnt = value.Count;
                var combo = (long)cnt * (cnt - 1) / 2 % mod;
                result = (result + pre * combo) % mod;
                pre = (pre + combo) % mod;
            }

            return (int)result % mod;
        }
    }
}
