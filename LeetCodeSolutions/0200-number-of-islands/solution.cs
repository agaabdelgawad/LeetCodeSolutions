public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid == null || grid.Length == 0) return 0;

        int noOfIslands = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                if(grid[i][j] == '1'){
                    noOfIslands++;
                    SinkSurroundIslands(grid, i, j, rows, cols);
                }
            }
        }

        return noOfIslands;
    }

    private void SinkSurroundIslands(char[][] grid, int i, int j, int rows, int cols){
        if(i < 0 || i >= rows || j < 0 || j >= cols || grid[i][j] == '0') return;

        grid[i][j] = '0';

        SinkSurroundIslands(grid, i + 1, j, rows, cols);
        SinkSurroundIslands(grid, i - 1, j, rows, cols);
        SinkSurroundIslands(grid, i, j + 1, rows, cols);
        SinkSurroundIslands(grid, i, j - 1, rows, cols);
    }
}
