namespace LeetCode.MaxConsecutiveOnes
{
    //https://leetcode.com/problems/max-consecutive-ones/description/
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var oneCount = 0;
            var temp = 0;
            for (int i = 0, n = nums.Length; i < n; i++)
            {
                if (nums[i] == 1)
                {
                    temp++;
                    if (temp > oneCount)
                    {
                        oneCount = temp;
                    }
                }
                else
                {
                    temp = 0;
                }
            }
            return oneCount;
        }
    }
}
