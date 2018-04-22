using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ContainsDuplicate
{
    //https://leetcode.com/problems/contains-duplicate/description/
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();

            for (int i = 0, n = nums.Length; i < n; i++)
            {
                if (!hashSet.Add(nums[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
