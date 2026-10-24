public class Solution {
    public int NumDecodings(string s) {
        if(s[0] == '0') return 0;

        int n = s.Length;
        int[] dp = new int[n+1];
        dp[0] = 1;
        dp[1] = 1;

        for(int i = 2; i < n+1; i++){
            int currentDigit = s[i-1] -'0';
            if(currentDigit != 0) dp[i] += dp[i-1];

            int combinedDigit = (s[i-2] - '0') * 10 + (s[i-1] - '0');
            if(combinedDigit >= 10 && combinedDigit <= 26) dp[i] += dp[i-2];

            if(dp[i] == 0) return 0;
        }

        return dp[n];
    }
}
