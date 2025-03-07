using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0367_Valid_Perfect_Square
    {
        public bool IsPerfectSquare(int num)
        {
            //runtime 100%
            //無條件進位==無條件捨去 =>整數
            var sqrt = Math.Sqrt(num);

            return Math.Floor(sqrt) == Math.Ceiling(sqrt);
        }
    }
}
