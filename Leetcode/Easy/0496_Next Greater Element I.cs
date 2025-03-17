using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _0496_Next_Greater_Element_I
    {
        //runtime 99%
        //紀錄index，然後查表  
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var result = new int[nums1.Length];
            var nums2Dic = new Dictionary<int, int>();

            for (var i = 0; i < nums2.Length; i++)
            {
                nums2Dic.Add(nums2[i], i);
            }

            for (var i = 0; i < nums1.Length; i++)
            {
                result[i] = -1;

                if (nums2Dic.TryGetValue(nums1[i], out int value))
                {
                    for (var j = value + 1; j < nums2.Length; j++)
                    {
                        if (nums2[j] > nums1[i])
                        {
                            result[i] = nums2[j];
                            break;
                        }
                    }
                }

            }

            return result;
        }
    }
}
