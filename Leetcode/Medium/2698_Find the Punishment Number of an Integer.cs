using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _2698_Find_the_Punishment_Number_of_an_Integer
    {
        public static int PunishmentNumber(int n)
        {
            var result = 0;
            var stack = new Stack<(int num, int target)>();
            for (var num = 1; num <= n; num++)
            {
                if (num == 1)
                {
                    result += 1;
                }

                var square = num * num;
                var canPartition = false;
                stack.Clear();
                stack.Push((square, num));
                while (stack.Count > 0)
                {
                    var (currentNum, currentTarget) = stack.Pop();

                    for (var i = 10; i < currentNum; i *= 10)
                    {
                        var newNum = currentNum / i;
                        var newTarget = currentTarget - currentNum % i;

                        if (newNum == newTarget)
                        {
                            canPartition = true;
                            break;
                        }

                        stack.Push((newNum, newTarget));
                    }
                }

                if (canPartition)
                {
                    result += square;
                }
            }

            return result;
        }
    }
}
