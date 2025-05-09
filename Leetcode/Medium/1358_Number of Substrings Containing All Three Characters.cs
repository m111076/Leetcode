﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1358_Number_of_Substrings_Containing_All_Three_Characters
    {
        public static int NumberOfSubstrings(string s)
        {
            //runtime 89%
            //time complexity O(n)
            //space complexity O(1)
            //滑動視窗
            //當滿足abc接有之後，window右端點至s尾端之組合皆符合需求
            var left = 0;
            var right = 0;
            var abcArr = new int[3];
            var result = 0;

            while (right < s.Length)
            {
                abcArr[s[right] - 'a']++;

                while (abcArr[0] >= 1 && abcArr[1] >= 1 && abcArr[2] >= 1)
                {
                    result += s.Length - right;
                    abcArr[s[left++] - 'a']--;
                }
                right++;
            }
            return result;

            //runtime 20%
            //var abcArr = new int[3];
            //var result = 0;

            //for (var i = 0; i < s.Length; i++)
            //{
            //    abcArr[s[i] - 'a'] = i + 1;

            //    if (!abcArr.Contains(0))
            //    {
            //        result += abcArr.Min();
            //    }
            //}
            //return result;

            //runtime 7%
            //var abcDic = new Dictionary<char, int>();
            //var result = 0;
            //var min = -1;

            //for (var i = 0; i < s.Length; i++)
            //{
            //    if (abcDic.TryGetValue(s[i], out int Idx))
            //    {
            //        abcDic[s[i]] = i;
            //    }
            //    else
            //    {
            //        abcDic.Add(s[i], i);
            //    }

            //    if (abcDic.Count == 3)
            //    {
            //        result++;
            //        min = abcDic.Min(s => s.Value);
            //        result += min;
            //    }
            //}

            //return result;
        }
    }
}
