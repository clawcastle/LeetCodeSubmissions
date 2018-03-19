using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.FindTheDifference
{
    public class Solution
    {
        //https://leetcode.com/problems/find-the-difference/description/
        public char FindTheDifference(string s, string t)
        {
            var firstStringSum = 0;

            for (int i = 0, n = s.Length; i < n; i++)
            {
                firstStringSum += s[i];
            }

            for (int i = 0, n = t.Length; i < n; i++)
            {
                firstStringSum -= t[i];
            }

            return (char)(firstStringSum * -1);
        }
    }
}
