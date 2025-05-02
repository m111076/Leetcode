using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal static class _3298_Count_Substrings_That_Can_Be_Rearranged_to_Contain_a_String_II
    {
        public static long ValidSubstringCount(string word1, string word2)
        {
            //runtime 75%
            //time complexity O(n)
            //space complexity O(1)
            var w1Arr = new int[128];
            var w2Arr = new int[128];
            var left = 0;
            var right = 0;
            var uniqleC2 = 0;
            var result = 0L;

            foreach (var c in word2)
            {
                if (w2Arr[c] == 0)
                    uniqleC2++;
                w2Arr[c]++;
            }

            var w2CinWindow = 0;

            while (right < word1.Length)
            {
                var target = word1[right];
                w1Arr[target]++;

                if (w1Arr[target] == w2Arr[target])
                    w2CinWindow++;

                while (w2CinWindow >= uniqleC2)
                {
                    var target1 = word1[left];
                    w1Arr[target1]--;
                    if (w1Arr[target1] < w2Arr[target1])
                        w2CinWindow--;
                    left++;
                }
                result += left;
                right++;
            }

            return result;

            //runtime 0%
            //var left = 0;
            //var right = 0;
            //var dic1 = new Dictionary<char, long>();
            //var dic2 = new Dictionary<char, long>();
            //var result = 0L;

            //foreach (var word in word2)
            //{
            //    if (!dic2.TryAdd(word, 1))
            //        dic2[word]++;
            //}

            //while (right < word1.Length)
            //{
            //    if (!dic1.TryAdd(word1[right], 1))
            //        dic1[word1[right]]++;

            //    while (left <= right && dic2.ContainsKey(word1[right]) && dic1[word1[right]] == dic2[word1[right]])
            //    {
            //        var IsMatch = true;

            //        foreach (var dic in dic2)
            //        {
            //            if (dic1.TryGetValue(dic.Key, out long value))
            //            {
            //                if (value < dic.Value)
            //                {
            //                    IsMatch = false;
            //                    break;
            //                }
            //            }
            //            else
            //            {
            //                IsMatch = false;
            //                break;
            //            }
            //        }

            //        if (IsMatch)
            //        {
            //            dic1[word1[left]]--;
            //            if (dic1[word1[left]] == 0)
            //                dic1.Remove(word1[left]);
            //            left++;
            //        }
            //        else
            //            break;
            //    }

            //    result += left;
            //    right++;
            //}

            //return result;
        }
    }
}
