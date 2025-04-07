using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1652_Defuse_the_Bomb
    {
        //runtime 100%
        //帶修改
        public int[] Decrypt(int[] code, int k)
        {
            var result = new int[code.Length];

            if (k == 0)
                return result;
            int start = 1, end = k, sum = 0;

            if (k < 0)
            {
                k = -k;
                start = code.Length - k;
                end = code.Length - 1;
            }

            for (int i = start; i <= end; i++)
            {
                sum += code[i];
            }

            for (int i = 0; i < code.Length; i++)
            {
                result[i] = sum;
                sum -= code[(start++) % code.Length];
                sum += code[(++end) % code.Length];
            }
            return result;
        }
    }
}
