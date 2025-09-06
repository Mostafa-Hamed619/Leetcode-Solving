namespace NeetCode.Medium.Arrays
{
    class Best_Time_to_Buy_and_Sell_Stock_II
    {
        public int MaxProfit(int[] prices)
        {
            int Profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[i - 1])
                    continue;
                else
                {
                    Profit += prices[i] - prices[i - 1];
                }
            }
            return Profit;
        }
    }
}
