namespace LeetCode.ReverseString
{
    //https://leetcode.com/problems/reverse-string/description/
    public class Solution
    {
        public string ReverseString(string s)
        {
            var reversedString = new char[s.Length];
            for (int i = 0, n = s.Length; i < n; i++)
            {
                reversedString[n - (i + 1)] = s[i];
            }
            return new string(reversedString);
        }
    }
}
