namespace LeetCode.SingleNumber
{
    //https://leetcode.com/problems/single-number/description/
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            var number = 0;
            for (int i = 0, n = nums.Length; i < n; i++)
            {
                number ^= nums[i];
            }

            return number;
        }
    }
}
