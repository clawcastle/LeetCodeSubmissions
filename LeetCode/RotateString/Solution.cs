namespace LeetCode.RotateString
{
    //https://leetcode.com/problems/rotate-string/description/
    public class Solution
    {
        public bool RotateString(string A, string B)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            for (int i = 0, n = A.Length; i < n; i++)
            {
                ShiftString(ref A, n);
                if (A == B)
                {
                    return true;
                }
            }
            return false;
        }

        public void ShiftString(ref string input, int inputLength)
        {
            var leftMost = input[0];
            var outString = input.Substring(1, inputLength - 1);

            outString += leftMost;
            input = outString;
        }
    }
}
