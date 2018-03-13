using System.Linq;

namespace LeetCode.MajorityElement
{
    //https://leetcode.com/problems/majority-element/description/
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var length = nums.Length;
            if (length == 1)
            {
                return nums[0];
            }
            var groups = nums.GroupBy(x => x);

            foreach (var g in groups)
            {
                if (g.Count() > length / 2)
                {
                    return g.Key;
                }
            }
            return 0;
        }
    }
}
