using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SortColors
{
    //https://leetcode.com/problems/sort-colors/description/
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            var countingArray = new int[nums.Max() + 1];

            for (int i = 0, n = nums.Length; i < n; i++)
            {
                countingArray[nums[i]]++;
            }

            var count = 0;
            for (int i = 0, n = countingArray.Length; i < n; i++)
            {
                while (countingArray[i] > 0)
                {
                    nums[count] = i;
                    count++;
                    countingArray[i]--;
                }
            }
        }
    }
}
