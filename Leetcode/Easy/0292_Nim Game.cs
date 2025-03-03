using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0292_Nim_Game
    {
        public bool CanWinNim(int n)
        {
            //runtime 100% 這考數學吧
            return n % 4 != 0;
        }
    }
}
