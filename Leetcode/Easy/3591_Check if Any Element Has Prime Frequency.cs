using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3591_Check_if_Any_Element_Has_Prime_Frequency
    {
        public bool CheckPrimeFrequency(int[] nums)
        {
            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            var amount = new int[101];

            foreach (var i in nums)
            {
                amount[i]++;
            }

            foreach (var a in amount)
            {
                if (a == 0 || a == 1)
                    continue;
                if (a == 2)
                    return true;
                if (a % 2 == 0)
                    continue;
                var max = (int)Math.Sqrt(a);
                var IsPrime = true;

                for (var i = 3; i <= max; i++)
                {
                    if (a % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                    return true;
            }

            return false;
        }
    }
}
