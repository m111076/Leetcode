using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0168_Excel_Sheet_Column_Title
    {
        public string ConvertToTitle(int columnNumber)
        {
            if (columnNumber == 0) return "";
            columnNumber--;
            var targetVal = columnNumber % 26;
            var targetChar = (Char)('A' + targetVal);
            return ConvertToTitle(columnNumber / 26) + targetChar;
        }
    }
}
