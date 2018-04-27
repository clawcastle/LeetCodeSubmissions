using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.FirstMissingPositive
{
    //https://leetcode.com/problems/first-missing-positive/description/
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 1;
            }
            var max = nums.Max();
            if (max <= 0)
            {
                return 1;
            }
            var countingArray = new int[max + 1];

            for (int i = 0, n = nums.Length; i < n; i++)
            {
                if (nums[i] >= 0)
                {
                    countingArray[nums[i]]++;
                }
            }

            for (int i = 1, n = countingArray.Length; i < n; i++)
            {
                if (countingArray[i] == 0)
                {
                    return i;
                }
            }
            return max + 1;
        }
    }
}
