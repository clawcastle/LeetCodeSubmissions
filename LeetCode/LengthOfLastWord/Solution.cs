using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LengthOfLastWord
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var count = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (count > 0 && s[i] == ' ')
                {
                    break;
                }
                if (s[i] != ' ')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
