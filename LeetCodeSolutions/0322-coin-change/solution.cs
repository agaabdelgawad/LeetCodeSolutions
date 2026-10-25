public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];

        int maxVal = amount + 1;
        Array.Fill(dp, maxVal);

        dp[0] = 0;

        for(int i = 1; i <= amount; i++){
            foreach(int coin in coins){
                if(coin <= i){
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}
