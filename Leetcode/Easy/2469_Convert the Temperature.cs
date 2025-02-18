using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _2469_Convert_the_Temperature
    {
        public static double[] ConvertTemperature(double celsius)
        {
            var ans = new double[2];
            ans[0] = celsius + 273.15;
            ans[1] = celsius * 1.8 + 32;

            return ans;
        }
    }
}
