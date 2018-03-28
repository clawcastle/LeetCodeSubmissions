using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Search2DMatrix
{
    //https://leetcode.com/problems/search-a-2d-matrix/description/
    public class Solution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix.Length == 0)
            {
                return false;
            }

            var row = -1;
            var rowLength = matrix.GetLength(1) - 1;


            for (int i = 1, n = matrix.GetLength(0); i < n; i++)
            {
                if (matrix[i, rowLength] >= target && matrix[i - 1, rowLength] < target)
                {
                    row = i;
                }
            }

            if (row == -1)
            {
                if (matrix[0, rowLength] >= target)
                {
                    row = 0;
                }
                else
                {
                    return false;
                }
            }


            for (int i = 0, n = matrix.GetLength(1); i < n; i++)
            {
                if (matrix[row, i] == target)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
