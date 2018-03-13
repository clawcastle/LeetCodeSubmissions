using System;

namespace LeetCode.ReverseInteger
{
    public class Solution
    {
        //https://leetcode.com/problems/reverse-integer/description/
        public int Reverse(int x)
        {
            var resultString = "";
            var isNegative = false;

            if (x < 0)
            {
                if (x == Int32.MinValue)
                {
                    return 0;
                }
                isNegative = true;
                x = x * -1;
            }

            while (x >= 10)
            {
                var remainder = x % 10;
                resultString += Convert.ToString(remainder);
                x /= 10;
            }
            resultString += Convert.ToString(x);

            if (Int32.TryParse(resultString, out var result))
            {
                if (isNegative)
                {
                    result = result * -1;
                }
                return result;
            }
            return 0;
        }
    }
}
