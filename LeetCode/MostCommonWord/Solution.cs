using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MostCommonWord
{
    //https://leetcode.com/problems/most-common-word/description/
    public class Solution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var paragraphAsLowerCase = paragraph.ToLower();
            var words = new Dictionary<string, int>();
            var count = 0;
            var tempWord = "";

            while (count != paragraphAsLowerCase.Length)
            {
                if (paragraphAsLowerCase[count] >= 97 && paragraphAsLowerCase[count] <= 122)
                {
                    tempWord += paragraphAsLowerCase[count];
                }
                else
                {
                    if (tempWord != "")
                    {
                        AddToDictionary(words, tempWord);
                        tempWord = "";
                    }
                }
                count++;
            }

            if (tempWord != "")
            {
                AddToDictionary(words, tempWord);
            }

            var max = -1;
            var output = "";

            foreach (var word in words)
            {
                if (word.Value > max)
                {
                    if (Array.IndexOf(banned, word.Key) < 0)
                    {
                        output = word.Key;
                        max = word.Value;
                    }
                }
            }

            return output;
        }

        private void AddToDictionary(Dictionary<string, int> words, string word)
        {
            if (words.ContainsKey(word))
            {
                words[word] = words[word] + 1;
            }
            else
            {
                words.Add(word, 1);
            }
        }
    }
}
