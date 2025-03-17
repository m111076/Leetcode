using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2206_Divide_Array_Into_Equal_Pairs
    {
        //runtime 100%
        //先記錄所有出現過的數字的數量
        //若是有奇數個的則不符合規定
        public bool DivideArray(int[] nums)
        {
            var tmp = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (tmp.ContainsKey(num))
                    tmp[num]++;
                else
                    tmp.Add(num, 1);
            }

            foreach (var value in tmp.Values)
            {
                if ((value & 1) != 0)
                    return false;
            }
            return true;
        }
    }
}
