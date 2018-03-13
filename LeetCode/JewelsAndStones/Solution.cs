namespace LeetCode.JewelsAndStones
{
    //https://leetcode.com/problems/jewels-and-stones/description/
    public class Solution
    {
        public int NumJewelsInStones(string J, string S)
        {
            var jewelCount = 0;
            foreach (var character in S)
            {
                for (int i = 0, n = J.Length; i < n; i++)
                {
                    if (character - J[i] == 0)
                    {
                        jewelCount++;
                    }
                }
            }

            return jewelCount;
        }
    }
}
