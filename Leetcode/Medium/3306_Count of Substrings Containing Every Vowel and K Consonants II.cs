using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3306_Count_of_Substrings_Containing_Every_Vowel_and_K_Consonants_II
    {
        public static long CountOfSubstrings(string word, int k)
        {

            var result = 0L;
            var length = word.Length;

            if (length < 5 + k)
                return result;

            var vowelSet = new HashSet<char>("aeiou");
            var tmpDic = new Dictionary<char, int>();
            var nextCons = new int[length];
            var Id = length;

            for (int i = length - 1; i >= 0; i--)
            {
                nextCons[i] = Id;
                if (!vowelSet.Contains(word[i]))
                    Id = i;
            }


            var normalCnt = 0;
            var left = 0;
            var right = 0;
            var leftvowel = 0;


            while (right < length)
            {
                if (vowelSet.Contains(word[right]))
                {
                    if (tmpDic.ContainsKey(word[right]))
                        tmpDic[word[right]]++;
                    else
                        tmpDic.Add(word[right], 1);
                }
                else
                    normalCnt++;

                while (normalCnt > k && left <= right)
                {
                    if (tmpDic.ContainsKey(word[left]))
                    {
                        if (--tmpDic[word[left]] == 0)
                        {
                            tmpDic.Remove(word[left++]);
                        }
                    }
                    else
                    {
                        normalCnt--;
                        left++;
                    }
                }

                while (normalCnt == k && tmpDic.Count == 5 && left < right)
                {
                    result += (nextCons[right] - right);

                    if (tmpDic.ContainsKey(word[left]))
                    {
                        if (tmpDic[word[left]] - 1 != 0)
                        {
                            tmpDic[word[left]]--;
                            left++;
                        }
                        else
                            break;
                    }
                    else
                    {
                        if (normalCnt - 1 < k)
                            break;
                    }
                }

                right++;
            }

            return result;

        }
    }
}
