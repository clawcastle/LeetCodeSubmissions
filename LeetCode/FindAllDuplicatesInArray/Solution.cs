using System.Collections.Generic;
using System.Linq;

namespace LeetCode.FindAllDuplicatesInArray
{
    //https://leetcode.com/problems/find-all-duplicates-in-an-array/description/
    public class Solution
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var elements = nums.GroupBy(i => i);
            var result = new List<int>();

            foreach (var element in elements)
            {
                if (element.Count() == 2)
                {
                    result.Add(element.Key);
                }
            }

            return result;
        }
    }
}
