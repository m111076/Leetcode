using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0275_H_Index_II
    {
        //runtime 100%
        //time complexity O(logn*logn)
        //邊界值要注意
        public int HIndex(int[] citations)
        {
            var left = 0;
            var right = citations.Length + 1;//0~8都是可以的

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(citations, mid))
                    left = mid + 1;
                else
                    right = mid;
            }

            return left - 1;
        }

        private bool Check(int[] citations, int h)
        {
            var left = 0;
            var right = citations.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (citations[mid] >= h)
                    right = mid;
                else
                    left = mid + 1;
            }

            return citations.Length - left >= h;
        }
    }
}
