using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    //runtime 100%
    public class _1863_Sum_of_All_Subset_XOR_Totals
    {
        public int SubsetXORSum(int[] nums)
        {
            return XOR(nums, 0, 0);
        }

        public int XOR(int[] iNums, int iIndex, int iValue)
        {
            if (iIndex == iNums.Length)
            {
                return iValue;
            }
            else
            {
                return XOR(iNums, iIndex + 1, iValue ^ iNums[iIndex]) + XOR(iNums, iIndex + 1, iValue);
            }
        }
    }
}
