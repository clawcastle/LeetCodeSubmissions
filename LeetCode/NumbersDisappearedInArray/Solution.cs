using System.Collections.Generic;

namespace LeetCode.NumbersDisappearedInArray
{
    //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var countingArray = new int[nums.Length + 1];

            for (int i = 0, n = nums.Length; i < n; i++)
            {
                countingArray[nums[i]]++;
            }

            var count = 0;
            for (int i = 1, n = countingArray.Length; i < n; i++)
            {
                if (countingArray[i] == 0)
                {
                    count++;
                }
            }

            var output = new int[count];
            count = 0;
            for (int i = 1, n = countingArray.Length; i < n; i++)
            {
                if (countingArray[i] == 0)
                {
                    output[count] = i;
                    count++;
                }
            }

            return output;
        }
    }
}
