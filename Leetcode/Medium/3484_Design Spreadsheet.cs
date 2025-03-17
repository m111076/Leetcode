using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3484_Design_Spreadsheet
    {
        public class Spreadsheet
        {

            public Dictionary<string, int> keyValuePairs;

            public Spreadsheet(int rows)
            {
                keyValuePairs = new Dictionary<string, int>();
            }

            public void SetCell(string cell, int value)
            {
                if (keyValuePairs.ContainsKey(cell))
                    keyValuePairs[cell] = value;
                else
                    keyValuePairs.Add(cell, value);
            }

            public void ResetCell(string cell)
            {
                if (keyValuePairs.ContainsKey(cell))
                    keyValuePairs[cell] = 0;
                else
                    keyValuePairs.Add(cell, 0);
            }

            public int GetValue(string formula)
            {
                var tmp = formula.Substring(1).Split('+');
                var result = 0;

                foreach (var i in tmp)
                {
                    if (!Char.IsLetter(i[0]))
                    {
                        var b = 1;
                        for (var c = i.Length - 1; c >= 0; c--)
                        {
                            result += int.Parse(i[c].ToString()) * b;
                            b *= 10;
                        }
                    }
                    else
                    {
                        if (keyValuePairs.TryGetValue(i, out int value))
                            result += value;
                    }
                }
                return result;
            }
        }
    }
}
