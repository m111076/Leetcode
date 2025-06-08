using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3577_Count_the_Number_of_Computer_Unlocking_Permutations
    {
        //runtime 57%
        //time complexity O(n)
        //space complexity O(1)
        //因為所有電腦都是由第一個來往後解鎖，所以只要確認後面的電腦的複雜度比第一個大就可以了
        //之後就是計算(N-1)!
        public int CountPermutations(int[] complexity)
        {
            var result = 1L;

            for (int i = 1; i<complexity.Length; i++)
            {
                if (complexity[0] < complexity[i])
                    result = result* i % 1_000_000_007;
                else
                    return 0;
            }

            return (int) result;
}
    }
}
