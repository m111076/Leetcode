using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0228_Summary_Ranges
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            //runtime 67% memory 23%
            if (nums.Length == 0) return new List<string>();
            if (nums.Length == 1) return new List<string>() { $"{nums[0]}" };

            var result = new List<string>();
            var target = nums[0];
            var tempLengh = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] - target == tempLengh)
                    tempLengh++;
                else
                {
                    if (tempLengh == 1)
                    {
                        result.Add($"{target}");
                    }
                    else
                    {
                        result.Add($"{target}->{nums[i - 1]}");
                    }

                    target = nums[i];
                    tempLengh = 1;
                }

                if (i == nums.Length - 1)
                {
                    if (tempLengh == 1)
                    {
                        result.Add($"{target}");
                    }
                    else
                    {
                        result.Add($"{target}->{nums[i]}");
                    }
                }
            }
            return result;

        }
    }
}
