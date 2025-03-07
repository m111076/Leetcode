using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0350_Intersection_of_Two_Arrays_II
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            //runtime95%
            //同349，只是要計數
            var numDic = new Dictionary<int, int>();
            var result = new List<int>();

            foreach (var num in nums1)
            {
                if (numDic.ContainsKey(num))
                    numDic[num]++;
                else
                    numDic.Add(num, 1);
            }

            foreach (var num in nums2)
            {
                if (numDic.ContainsKey(num))
                {
                    result.Add(num);
                    if (--numDic[num] == 0)
                        numDic.Remove(num);
                }
                if (numDic.Count == 0)
                    break;
            }
            return result.ToArray();
        }
    }
}
