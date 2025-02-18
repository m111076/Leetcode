using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _13_Roman_to_Integer
    {
        public int RomanToInt(string s)
        {
            var previous = 0;
            var result = 0;
            foreach (var c in s)
            {
                var current = Roman2Numeral(c);
                if (current > previous && previous != 0)
                {
                    result -= 2 * previous;
                    result += current;
                }
                else
                {
                    result += current;
                }
                previous = current;
            }
            return result;
        }

        public int Roman2Numeral(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            };
            return 0;
        }
    }
}
