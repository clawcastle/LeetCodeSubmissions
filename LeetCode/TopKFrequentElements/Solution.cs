using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TopKFrequentElements
{
    //https://leetcode.com/problems/top-k-frequent-elements/description/
    public class Solution
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0, n = nums.Length; i < n; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            var frequencies = dict.OrderByDescending(x => x.Value).Take(k).ToDictionary(x => x.Key);

            var output = new int[frequencies.Keys.Count];
            frequencies.Keys.CopyTo(output, 0);

            return output;
        }
    }
}
