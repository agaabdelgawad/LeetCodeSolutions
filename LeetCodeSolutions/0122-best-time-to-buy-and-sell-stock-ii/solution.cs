public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;

        for (int i = 0; i < prices.Length - 1; i++){
            maxProfit += (prices[i + 1] - prices[i]) > 0 ? prices[i + 1] - prices[i] : 0;
        }

        return maxProfit;
    }
}
