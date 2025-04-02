using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _3340_Check_Balanced_String
    {
        //runtime 100%
        //T: O(n);
        //S: O(1);
        //two pointer
        public bool IsBalanced(string num)
        {
            var evenPointer = 0;
            var oddPointer = 1;
            var even = 0L;
            var odd = 0L;

            while (evenPointer < num.Length || oddPointer < num.Length)
            {
                if (evenPointer < num.Length)
                {
                    even += num[evenPointer] - '0';
                }
                if (oddPointer < num.Length)
                {
                    odd += num[oddPointer] - '0';
                }

                evenPointer += 2;
                oddPointer += 2;
            }

            return even == odd;
        }
    }
}
