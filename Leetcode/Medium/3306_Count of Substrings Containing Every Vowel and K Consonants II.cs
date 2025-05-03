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
        //runtime 14%
        //time complexity O(n)
        //space complexity O(n)
        //滑動視窗 at least
        public long CountOfSubstrings(string word, int k)
        {
            return Check(word, k) - Check(word, k + 1);
        }

        private long Check(string word, int k)
        {
            var volews = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            var left = 0;
            var right = 0;
            var dic = new Dictionary<char, int>();
            var cnt = 0;
            var result = 0L;

            while (right < word.Length)
            {
                if (volews.Contains(word[right]))
                {
                    if (!dic.TryAdd(word[right], 1))
                        dic[word[right]]++;
                }
                else
                    cnt++;

                while (dic.Count == 5 && cnt >= k)
                {
                    var target = word[left++];
                    if (volews.Contains(target))
                    {
                        dic[target]--;
                        if (dic[target] == 0)
                            dic.Remove(target);
                    }
                    else
                    {
                        cnt--;
                    }
                }

                result += left;
                right++;
            }

            return result;
        }
    }
}
