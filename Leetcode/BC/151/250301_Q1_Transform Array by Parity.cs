using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BC
{
    public class _250301_Q1_Transform_Array_by_Parity
    {
        public int[] TransformArray(int[] nums)
        {
            var result1 = new List<int>();
            var result2 = new List<int>();

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    result1.Add(0);
                }
                else
                {
                    result2.Add(1);
                }
            }

            var result3 = result1.Concat(result2);
            var result = result3.ToArray();

            return result;
            
        }
    }
}
