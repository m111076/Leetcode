using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2579_Count_Total_Number_of_Colored_Cells
    {
        public long ColoredCells(int n)
        {
            //runtime 100%
            //觀察推出算式然後化簡n^2+(n-1)^2
            if (n == 0) return 0;
            long l = (long)n;

            return (l * l) + ((l - 1) * (l - 1));

            //runtime 37%
            //if (n == 0) return 0;

            //return (long)Math.Pow(n, 2) + (long)Math.Pow(n - 1, 2);
        }
    }
}
