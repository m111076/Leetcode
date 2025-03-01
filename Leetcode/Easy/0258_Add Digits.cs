using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0258_Add_Digits
    {
        public int Result = 0;

        public int AddDigits(int num)
        {
            //runtime 100%
            Result = Check(num);

            while (true)
            {
                if (Result / 10 == 0)
                    break;

                Result = Check(Result);
            }
            return Result;
        }

        public int Check(int iTarget)
        {
            var result = 0;

            while (iTarget > 0)
            {
                result += iTarget % 10;
                iTarget /= 10;
            }
            return result;
        }
    }
}
