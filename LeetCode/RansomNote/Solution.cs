using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RansomNote
{
    //https://leetcode.com/problems/ransom-note/description/
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var letters = new int[26];

            for (int i = 0, n = ransomNote.Length; i < n; i++)
            {
                letters[ransomNote[i] - 97]++;
            }

            for (int i = 0, n = magazine.Length; i < n; i++)
            {
                if (letters[magazine[i] - 97] != 0)
                {
                    letters[magazine[i] - 97]--;
                }
            }

            var count = 0;
            for (int i = 0, n = letters.Length; i < n; i++)
            {
                count += letters[i];
            }

            if (count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
