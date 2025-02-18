using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _70_Climbing_Stairs
    {
        public static int ClimbStairs(int n)
        {
            if (n <= 1) return 1;
            var stepRecord = new int[n];

            stepRecord[0] = 1; stepRecord[1] = 2;
            for (int i = 2; i < n; ++i)
            {
                stepRecord[i] = stepRecord[i - 1] + stepRecord[i - 2];
            }
            return stepRecord[n-1];

            //時間複雜度2^n
            //太花時間
            //if (n <= 0) return 0;
            //else if (n == 1) return 1;
            //else if (n == 2) return 2;
            //else return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }
    }
}
