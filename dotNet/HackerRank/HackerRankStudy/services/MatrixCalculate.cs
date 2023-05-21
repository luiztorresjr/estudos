using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankStudy.services
{
    public class MatrixCalculate
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int diagonalOne = 0;
            int diagonalTwo = 0;

            for (int r = 0; r < arr.Count; r++)
            {
                for (int c = 0; c < arr[r].Count; c++)
                {
                    if (r == c) diagonalOne += arr[r][c];
                    if ((r + c) == (arr.Count - 1)) diagonalTwo += arr[r][c];
                }
            }

            return Math.Abs(diagonalTwo - diagonalOne);
        }
    }
}
