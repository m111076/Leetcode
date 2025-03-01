using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0873_Length_of_Longest_Fibonacci_Subsequence
    {
        public int LenLongestFibSubseq(int[] arr)
        {
            //runtime38%
            var result = 0;
            var sumDic = new Dictionary<int, int>[arr.Length];

            for (var i = 0; i < arr.Length; i++)
            {
                sumDic[i] = new Dictionary<int, int>();
                
                for (var j = 0; j < i; j++)
                {
                    if (sumDic[j].ContainsKey(arr[i]))
                    {
                        var sum = arr[i] + arr[j];
                        sumDic[i].Add(sum, sumDic[j][arr[i]] + 1);
                        result = Math.Max(result, sumDic[i][sum]);
                    }
                    else
                    {
                        sumDic[i].Add((arr[j] + arr[i]), 2);
                    }
                }
            }
            return result;
        }
    }
}
