using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.IsomorphicStrings
{
    //https://leetcode.com/problems/isomorphic-strings/description/
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dictionary = new Dictionary<char, char>();
            var reverseDictionary = new Dictionary<char, char>();

            for (int i = 0, n = s.Length; i < n; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                {
                    if (dictionary[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                if (reverseDictionary.ContainsKey(t[i]))
                {
                    if (reverseDictionary[t[i]] != s[i])
                    {
                        return false;
                    }
                }
                else
                {
                    dictionary.Add(s[i], t[i]);
                    reverseDictionary.Add(t[i], s[i]);
                }
            }

            return true;
        }
    }
}
