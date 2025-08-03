using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _0197_Rising_Temperature
    {
        public void MySQL()
        {
            //select w1.id from Weather as w1,Weather as w2
            //where DATEDIFF(w1.recordDate, w2.recordDate)= 1
            //and w1.temperature > w2.temperature;

            //SELECT w1.id
            //FROM Weather AS w1
            //JOIN Weather AS w2
            //  ON DATEDIFF(w1.recordDate, w2.recordDate) = 1
            //WHERE w1.temperature > w2.temperature;
        }
    }
}
