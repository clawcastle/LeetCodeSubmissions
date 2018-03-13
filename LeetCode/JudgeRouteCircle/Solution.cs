namespace LeetCode.JudgeRouteCircle
{
    //https://leetcode.com/problems/judge-route-circle/description/
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            var result = 0;

            for (int i = 0, n = moves.Length; i < n; i++)
            {
                if (moves[i] == 'U')
                {
                    result += 1;
                }
                if (moves[i] == 'R')
                {
                    result += 1;
                }
                if (moves[i] == 'D')
                {
                    result -= 1;
                }
                if (moves[i] == 'L')
                {
                    result -= 1;
                }
            }

            return (result == 0);
        }
    }
}
