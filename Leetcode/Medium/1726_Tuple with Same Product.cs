using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1726_Tuple_with_Same_Product
    {
        public int TupleSameProduct(int[] nums)
        {
            //runtime 40%
            var targetDic = new Dictionary<int, int>();
            var cnt = 0;
            var length = nums.Length;

            for (var i = 0; i < length; i++)
            {
                for (var j = i + 1; j < length; j++)
                {
                    var mul = nums[i] * nums[j];
                    if (targetDic.ContainsKey(mul))
                    {
                        cnt += targetDic[mul];
                        targetDic[mul]++;
                    }
                    else
                    {
                        targetDic[mul] = 1;
                    }
                }
            }

            return cnt * 8;
        }
    }
}
