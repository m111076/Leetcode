using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0219_Contains_Duplicate_II
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            //runtime 83% memory 63%
            //針對nums逐一搜尋
            //若沒出現在dic內則將加入(數字，index)加入
            //若出現則取出idx計算
            //若計算後符合條件則輸出true，未滿足條件則使用新idx取代原有的
            var tempDic = new Dictionary<int, int>();

            var l = nums.Length;

            for (var i = 0; i < l; i++)
            {
                if (tempDic.TryGetValue(nums[i], out int val))
                {
                    if (i - val <= k)
                        return true;
                    else
                        tempDic[nums[i]] = i;
                }
                else
                {
                    tempDic[nums[i]] = i;
                }
            }
            return false;
        }
    }
}
