namespace NeetCode.Easy.Arrays
{
    class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int Min = prices[0];
            int profit = 0;
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (Min > prices[i])
                    Min = prices[i];
                else
                {
                    profit = prices[i] - Min;
                    if (maxProfit < profit)
                        maxProfit = profit;
                }
            }

            return maxProfit;
        }
    }
}
