using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    //runtime 100%
    //time complexity O(n)
    //space complexity O(1)
    internal class _3232_Find_if_Digit_Game_Can_Be_Won
    {
        public bool CanAliceWin(int[] nums)
        {
            var tmp = 0;

            foreach (int num in nums)
            {
                if (num.ToString().Length == 1)
                {
                    tmp += num;
                }
                else
                {
                    tmp -= num;
                }
            }

            return tmp != 0;
        }
    }
}
