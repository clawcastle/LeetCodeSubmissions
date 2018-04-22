using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WordPattern
{
    //https://leetcode.com/problems/word-pattern/description/
    public class Solution
    {
        public bool WordPattern(string pattern, string str)
        {
            var dictionary = new Dictionary<char, string>();
            var reverseDictionary = new Dictionary<string, char>();

            var strWords = str.Split(' ');

            if (pattern.Length != strWords.Length)
            {
                return false;
            }

            for (int i = 0, n = pattern.Length; i < n; i++)
            {
                if (dictionary.ContainsKey(pattern[i]))
                {
                    if (dictionary[pattern[i]] != strWords[i])
                    {
                        return false;
                    }
                }
                if (reverseDictionary.ContainsKey(strWords[i]))
                {
                    if (reverseDictionary[strWords[i]] != pattern[i])
                    {
                        return false;
                    }
                }
                else
                {
                    dictionary.Add(pattern[i], strWords[i]);
                    reverseDictionary.Add(strWords[i], pattern[i]);
                }
            }
            return true;
        }
    }
}
