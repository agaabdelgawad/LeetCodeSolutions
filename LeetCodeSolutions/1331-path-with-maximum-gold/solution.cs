public class Solution {
    private int _maxGold = 0;

    public int GetMaximumGold(int[][] grid) {
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[0].Length; j++){
                _maxGold = Math.Max(_maxGold, Backtrack(i, j, grid));
            }
        }

        return _maxGold;
    }

    private int Backtrack(int r, int c, int[][] grid){
        if(r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || grid[r][c] == 0){
            return 0;
        }

        int currentGold = grid[r][c];

        grid[r][c] = 0;

        int left = Backtrack(r-1, c, grid);
        int right = Backtrack(r+1, c, grid);
        int up = Backtrack(r, c-1, grid);
        int down = Backtrack(r, c+1, grid);

        grid[r][c] = currentGold;

        return currentGold + Math.Max(Math.Max(left, right), Math.Max(up, down));
    }
}
