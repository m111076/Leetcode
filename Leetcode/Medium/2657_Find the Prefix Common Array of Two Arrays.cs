using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2657_Find_the_Prefix_Common_Array_of_Two_Arrays
    {
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            //可利用XOR
            //runtime 96%
            //time complexity O(n)
            //space complexity O(n)
            //利用XOR機制
            //A XOR A = 0,A XOR 0 = A
            var result = new int[A.Length];
            var commonArr = new int[A.Length + 1];
            var commonCnt = 0;

            for (var i = 0; i < A.Length; i++)
            {
                commonArr[A[i]] ^= A[i];
                if (commonArr[A[i]] == 0)
                {
                    commonCnt++;
                }
                commonArr[B[i]] ^= B[i];
                if (commonArr[B[i]] == 0)
                {
                    commonCnt++;
                }
                result[i] = commonCnt;
            }
            return result;

            //runtime 34%
            //time complexity O(n)
            //space complexity O(n)
            //var result = new int[A.Length];
            //var setA = new HashSet<int>();
            //var setB = new HashSet<int>();
            //result[0] = A[0] == B[0] ? 1 : 0;
            //setA.Add(A[0]);
            //setB.Add(B[0]);

            //for (int i = 1; i < A.Length; i++)
            //{
            //    result[i] = result[i - 1];
            //    var a = A[i];
            //    var b = B[i];
            //    setA.Add(a);
            //    setB.Add(b);

            //    if (a == b)
            //    {
            //        result[i]++;
            //        continue;
            //    }

            //    if (setA.Contains(b))
            //    {
            //        result[i]++;
            //    }

            //    if (setB.Contains(a))
            //    {
            //        result[i]++;
            //    }
            //}

            //return result;
        }
    }
}
