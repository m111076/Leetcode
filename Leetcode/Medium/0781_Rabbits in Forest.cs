using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0781_Rabbits_in_Forest
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        //將每個兔子回答的數字視為一個群組，當群組的數量等於兔子回答的數字+1時，則可以確定這些兔子的數量
        public int NumRabbits(int[] answers)
        {
            var result = 0;
            var tmpDic = new Dictionary<int, int>();

            foreach (var answer in answers)
            {
                if (tmpDic.ContainsKey(answer))
                {
                    tmpDic[answer]++;
                }
                else
                {
                    tmpDic.Add(answer, 1);
                }
                if (tmpDic[answer] == answer + 1)
                {
                    result += answer + 1;
                    tmpDic.Remove(answer);
                }
            }

            foreach (var item in tmpDic)
            {
                result += item.Key + 1;
            }

            return result;
        }
    }
}
