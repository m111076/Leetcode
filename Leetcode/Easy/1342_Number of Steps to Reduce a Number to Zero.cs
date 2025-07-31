using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1342_Number_of_Steps_to_Reduce_a_Number_to_Zero
    {
        //runtime 100%
        //time complexity O(1)
        //space complexity O(1)
        //觀察法
        public int NumberOfSteps(int num)
        {
            var bitCnt = BitOperations.PopCount((uint)num);
            var highIdx = BitOperations.Log2((uint)num);

            return bitCnt + highIdx;
        }
    }
}
