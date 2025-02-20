using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1980_Find_Unique_Binary_String
    {
        public string FindDifferentBinaryString(string[] nums)
        {

            //runtine 100%
            var nCnt = nums.Length;
            var result = string.Empty;

            for (var i = 0; i < nCnt; i++)
            {
                result += nums[i][i].ToString() == "1" ? "0" : "1";
            }
            return result.ToString();
        }
    }
}
