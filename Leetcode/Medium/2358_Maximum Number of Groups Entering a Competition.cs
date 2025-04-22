using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2358_Maximum_Number_of_Groups_Entering_a_Competition
    {
        //runtime 50%
        //time complexity O(nlogn)
        //space complexity O(1)
        //排序過後，以選擇的組別的值來說G1的值一定會小於G2
        //因此我們只要確認由1+...+K會小於等於grades時K的最大值為多少
        public int MaximumGroups(int[] grades)
        {
            Array.Sort(grades);
            var length = grades.Length;
            var sum = 0;
            var k = 0;
            for (var i = 1; sum + i <= length; i++)
            {
                sum += i;
                k++;
            }
            return k;
        }
    }
}
