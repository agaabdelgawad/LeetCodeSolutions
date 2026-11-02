public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length;
        int n = text2.Length;

        int[][] dp = new int[m+1][];
        for(int i = 0; i < m+1; i++) dp[i] = new int[n+1];

        for(int i = 1; i < m+1; i++){
            for(int j = 1; j < n+1; j++){
                if(text1[i-1] == text2[j-1]) dp[i][j] = 1 + dp[i-1][j-1];
                else dp[i][j] = Math.Max(dp[i-1][j], dp[i][j-1]);
            }
        }

        return dp[m][n];
    }
}
