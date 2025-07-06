using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _3609_Minimum_Moves_to_Reach_Target_in_Grid
    {
        public int MinMoves(int sx, int sy, int tx, int ty)
        {
            var result = 0;

            while (tx != 0 || ty != 0)
            {
                if (tx < sx || ty < sy)
                    return -1;

                if (tx == sx && ty == sy)
                    return result;

                if (tx == ty)
                {
                    if (sx == 0)
                        tx -= ty;
                    else
                        ty -= tx;
                    result++;
                    continue;
                }

                if (tx < ty)
                {
                    (tx, ty) = (ty, tx);
                    (sx, sy) = (sy, sx);
                }

                if (tx >= 2 * ty)
                {
                    if (tx % 2 != 0)
                        return -1;
                    tx /= 2;
                }
                else
                {
                    tx -= ty;
                }

                result++;
            }

            return result;
        }
    }
}
