namespace LeetCode.IslandPerimeter
{
    //https://leetcode.com/problems/island-perimeter/description/
    public class Solution
    {
        public int IslandPerimeter(int[,] grid)
        {
            var perimeter = 0;

            for (int i = 0, rows = grid.GetLength(0); i < rows; i++)
            {
                for (int j = 0, cols = grid.GetLength(1); j < cols; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        perimeter += 4;

                        if (i < rows - 1 && grid[i + 1, j] == 1)
                        {
                            perimeter -= 2;
                        }
                        if (j > 0 && grid[i, j - 1] == 1)
                        {
                            perimeter -= 2;
                        }
                    }
                }
            }

            return perimeter;
        }
    }
}
