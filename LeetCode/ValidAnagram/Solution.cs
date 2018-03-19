using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ValidAnagram
{
    //https://leetcode.com/problems/valid-anagram/description/
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var letters = new int[26];
            var nonMatchingCount = 0;

            for (int i = 0, n = s.Length; i < n; i++)
            {
                letters[(s[i] - 97)]++;
                nonMatchingCount++;
            }

            for (int i = 0, n = t.Length; i < n; i++)
            {
                if (letters[t[i] - 97] != 0)
                {
                    letters[t[i] - 97]--;
                    nonMatchingCount--;
                }
            }

            if (nonMatchingCount == 0)
            {
                return true;
            }
            return false;
        }
    }
}
