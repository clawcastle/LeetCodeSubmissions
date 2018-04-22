using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.PascalsTriangle
{
    //https://leetcode.com/problems/pascals-triangle/description/
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var triangle = new List<List<int>>();
            if (numRows == 0)
            {
                return triangle.ToArray();
            }

            triangle.Add(new List<int> { 1 });

            for (int i = 1; i < numRows; i++)
            {
                triangle.Add(GenerateRow(triangle[i - 1], i + 1));
            }

            return triangle.ToArray();
        }

        public List<int> GenerateRow(List<int> formerRow, int rowNumber)
        {
            var row = new List<int>();
            for (int i = 0, n = rowNumber; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    row.Add(1);
                }
                else
                {
                    row.Add(formerRow[i - 1] + formerRow[i]);
                }
            }
            return row;
        }
    }
}
