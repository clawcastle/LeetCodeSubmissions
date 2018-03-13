using System;

namespace LeetCode.BestTimeToBuySellStock
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var minPrice = Int32.MaxValue;
            var maxProfit = 0;

            for (int i = 0, n = prices.Length; i < n; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }
    }
}
