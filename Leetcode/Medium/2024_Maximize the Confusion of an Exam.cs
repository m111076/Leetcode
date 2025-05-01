using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _2024_Maximize_the_Confusion_of_an_Exam
    {
        //runtime 90%
        //Time Complexity O(n)
        public static int MaxConsecutiveAnswers(string answerKey, int k)
        {
            var left = 0;
            var right = 0;
            var result = 0;
            var tCnt = 0;
            var fCnt = 0;


            while (right < answerKey.Length)
            {
                var t = answerKey[right] == 'T' ? tCnt++ : fCnt++;

                while (tCnt > k && fCnt > k)
                {
                    t = answerKey[left++] == 'T' ? tCnt-- : fCnt--;
                }

                result = Math.Max(result, right - left + 1);
                right++;
            }

            return result;
        }
    }
}
