using System;
using System.Collections.Generic;

namespace LeetCode.FizzBuzz
{
    //https://leetcode.com/problems/fizz-buzz/description/
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            var result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(Convert.ToString(i));
                }
            }
            return result;
        }
    }
}
