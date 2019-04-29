public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = Int32.MaxValue, maxProfit = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            // record min price:
            int price = prices[i];
            if(price < minPrice)
            {
                minPrice = price;
            }

            // record max profit:
            int diff = price - minPrice;
            if(diff > maxProfit)
            {
                maxProfit = diff;
            }
        }
        return maxProfit;
    }
}