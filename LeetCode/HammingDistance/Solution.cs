namespace LeetCode.HammingDistance
{
    //https://leetcode.com/problems/hamming-distance/description/
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            var xorResult = x ^ y;

            var distance = 0;

            while (xorResult != 0)
            {
                distance++;
                xorResult &= xorResult - 1;
            }

            return distance;
        }
    }
}
