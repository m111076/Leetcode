using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1780_Check_if_Number_is_a_Sum_of_Powers_of_Three
    {
        public bool CheckPowersOfThree(int n)
        {
            while (n > 0)
            {
                if (n % 3 == 2)
                    return false;
                n /= 3;
            }
            return true;
        }
    }
}
