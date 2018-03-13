namespace LeetCode.TwoSum
{
    public class Solution
    {
        //https://leetcode.com/problems/two-sum/description/
        public int[] TwoSum(int[] nums, int target)
        {
            var sum = 0;
            var result = new int[2];

            for (int i = 0, n = nums.Length; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        result = new int[] { i, j };
                    }
                }
            }
            return result;
        }
    }
}
