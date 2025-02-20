using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0202_Happy_Number
    {
        public bool IsHappy(int n)
        {
            //Runtime 66%
            var initial = n;
            var target = 0;
            var nums = new Dictionary<int, int>();

            while (initial != 0)
            {
                var last = initial % 10;
                target += (int)Math.Pow(last, 2);
                initial /= 10;
                if (initial == 0)
                {
                    if (target == 1)
                        return true;
                    else
                    {
                        if (nums.ContainsKey(target))
                            return false;
                        nums.Add(target, 1);
                        initial = target;
                        target = 0;
                    }
                }
            }
            return false;
        }
    }
}
