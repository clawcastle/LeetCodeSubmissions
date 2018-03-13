namespace LeetCode.BestTimeToBuySellStock2
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;

            for (int i = 1, n = prices.Length; i < n; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }
            return maxProfit;
        }
    }
}
