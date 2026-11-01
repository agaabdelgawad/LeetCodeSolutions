public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int[][] maxSideArr = new int[m][];
        for(int i = 0; i < m; i++) maxSideArr[i] = new int[n];

        int maxSide = 0;

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(matrix[i][j] == '1'){
                    if(i == 0 || j == 0){
                        maxSideArr[i][j] = 1;
                    }
                    else{
                        maxSideArr[i][j] = Math.Min(maxSideArr[i-1][j],
                                                    Math.Min(maxSideArr[i][j-1],
                                                             maxSideArr[i-1][j-1])) + 1;
                    }

                    maxSide = Math.Max(maxSide, maxSideArr[i][j]);
                }
            }
        }

        return maxSide * maxSide;
    }
}
