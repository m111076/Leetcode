using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0500_Keyboard_Row
    {
        //runtime:76%
        public string[] FindWords(string[] words)
        {
            var row1 = new HashSet<char> { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            var row2 = new HashSet<char> { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            var row3 = new HashSet<char> { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            var result = new List<string>();

            foreach (var word in words)
            {
                var lowerWord = word.ToLower();
                var row = lowerWord[0] switch
                {
                    var c when row1.Contains(c) => row1,
                    var c when row2.Contains(c) => row2,
                    var c when row3.Contains(c) => row3,
                    _ => throw new Exception()
                };
                var isSameRow = true;
                for (int i = 1; i < lowerWord.Length; i++)
                {
                    if (!row.Contains(lowerWord[i]))
                    {
                        isSameRow = false;
                        break;
                    }
                }
                if (isSameRow)
                {
                    result.Add(word);
                }
            }

            return result.ToArray();
        }
    }
}
