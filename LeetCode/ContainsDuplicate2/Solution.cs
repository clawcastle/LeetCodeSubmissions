using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ContainsDuplicate2
{
    //https://leetcode.com/problems/contains-duplicate-ii/description/
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0, n = nums.Length; i < n; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    if (IsCloseEnough(dictionary[nums[i]], i, k))
                    {
                        return true;
                    }
                    dictionary[nums[i]] = i;
                }
                else
                {
                    dictionary.Add(nums[i], i);
                }
            }
            return false;
        }

        public bool IsCloseEnough(int index1, int index2, int distance)
        {
            if (index2 - index1 <= distance)
            {
                return true;
            }
            return false;
        }
    }
}
