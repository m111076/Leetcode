using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0349_Intersection_of_Two_Arrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            //runtime97.54%
            var tmpDic = new Dictionary<int, int>();
            var result = new List<int>();
            foreach (var num in nums1)
            {
                if (!tmpDic.ContainsKey(num))
                    tmpDic.Add(num, num);
            }

            foreach (var num in nums2)
            {
                if (tmpDic.ContainsKey(num))
                    result.Add(num);
                tmpDic.Remove(num);
                if (tmpDic.Count == 0)
                    break;
            }
            return result.ToArray();

            //runtime 22%
            //var longer = nums1.Length > nums2.Length ? nums1 : nums2;
            //var shorter = longer == nums1 ? nums2 : nums1;
            //var result = new Dictionary<int, int>();

            //foreach (var i in longer)
            //{
            //    if (shorter.Contains(i))
            //        if (!result.ContainsKey(i))
            //            result.Add(i, i);
            //}
            //return result.Select(i => i.Key).ToArray();

        }
    }
}
