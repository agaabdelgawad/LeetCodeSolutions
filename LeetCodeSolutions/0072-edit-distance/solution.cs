public class Solution {
    public int MinDistance(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;
        int[,] match = new int[m + 1, n + 1];

        for(int i = 0; i <= m; i++) match[i, 0] = i;
        for(int j = 0; j <= n; j++) match[0, j] = j;

        for(int i = 1; i <= m; i++){
            for(int j = 1; j <= n; j++){
                if(word1[i - 1] == word2[j - 1]){
                    match[i, j] = match[i - 1, j - 1];
                }
                else{
                    int replace = match[i - 1, j - 1];
                    int delete = match[i - 1, j];
                    int insert = match[i , j - 1];
                    match[i, j] = 1 + Math.Min(replace, Math.Min(delete, insert));
                }
            }
        }

        return match[m, n];
    }
}
