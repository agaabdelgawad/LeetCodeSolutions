public class Solution {
    public int OrangesRotting(int[][] grid) {
        int minutes = 0;
        int freshCount = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;
        Queue<int[]> queue = new Queue<int[]>();
        int[][] directions = new int[][]{
            new int[]{1, 0},
            new int[]{-1, 0},
            new int[]{0, 1},
            new int[]{0, -1}
        };

        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                if(grid[i][j] == 2) queue.Enqueue(new int[]{i, j});
                else if(grid[i][j] == 1) freshCount++;
            }
        }

        while(queue.Count > 0 && freshCount > 0){
            minutes++;
            int count = queue.Count;

            while(count-- > 0){
                int[] current = queue.Dequeue();

                for(int k = 0; k < directions.Length; k++){
                    int newRow = current[0] + directions[k][0];
                    int newCol = current[1] + directions[k][1];

                    if(newRow >= 0 && newRow < rows &&
                       newCol >= 0 && newCol < cols &&
                       grid[newRow][newCol] == 1){
                          grid[newRow][newCol] = 2;
                          queue.Enqueue(new int[]{newRow, newCol});
                          freshCount--;
                    }
                }
            }    
        }

        return freshCount == 0 ? minutes : -1;
    }
}
