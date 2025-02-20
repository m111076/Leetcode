using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0217_Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            //runtime 84% memory88%
            //return new HashSet<int>(nums).Count != nums.Length;

            //runtime 71% memory 87%
            return nums.Length != nums.Distinct().Count();
        }
    }
}
