using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0409_Longest_Palindrome
    {
        public int LongestPalindrome(string s)
        {
            //runtime 98%
            var record = new int[128];
            var result = 0;
            var IsOdd = false;

            foreach (var c in s)
            {
                record[c]++;
            }

            foreach (var c in record)
            {
                if (c % 2 == 0)
                    result += c;
                else
                {
                    result += c - 1;
                    IsOdd = true;
                }
            }

            return IsOdd ? result + 1 : result;


            //runtime 67%
            //var charSet = new HashSet<char>();
            //var setCnt = 0;

            //foreach (var c in s)
            //{
            //    if (charSet.Contains(c))
            //    {
            //        charSet.Remove(c);
            //        setCnt++;
            //    }
            //    else
            //    {
            //        charSet.Add(c);
            //    }
            //}
            //if (charSet.Count != 0)
            //{
            //    return setCnt * 2 + 1;
            //}
            //else
            //{
            //    return setCnt * 2;
            //}
        }
    }
}
