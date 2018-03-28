using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ImplementStrStr
{
    //https://leetcode.com/problems/implement-strstr/description/
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == needle)
            {
                return 0;
            }

            for (int i = 0, n = haystack.Length + 1 - needle.Length; i < n; i++)
            {
                var tempNeedle = haystack.Substring(i, needle.Length);
                if (needle == tempNeedle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
