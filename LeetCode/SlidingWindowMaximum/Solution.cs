using System;

namespace LeetCode.SlidingWindowMaximum
{
    //https://leetcode.com/problems/sliding-window-maximum/description/
    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0)
            {
                return nums;
            }

            var window = new int[(nums.Length - k) + 1];

            for (int i = 0, n = (nums.Length - k) + 1; i < n; i++)
            {
                var windowMax = Int32.MinValue;
                for (int j = 0; j < k; j++)
                {
                    if (nums[j + i] > windowMax)
                    {
                        windowMax = nums[i + j];
                    }
                }
                window[i] = windowMax;
            }

            return window;
        }
    }
}
