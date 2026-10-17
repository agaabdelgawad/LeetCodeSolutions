public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        int n = grid.Length;
        if(grid[0][0] == 1 || grid[n-1][n-1] == 1) return -1;

        int[][] directions = new int[][] {
            new int[]{-1,-1}, new int[]{-1,0}, new int[]{-1,1}, // top
            new int[]{0,-1},                   new int[]{0,1}, // sides
            new int[]{1,-1},  new int[]{1,0},  new int[]{1,1} // bottom
        };

        int pathLength = 1;

        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[]{0, 0});
        grid[0][0] = 1;

        while(queue.Count > 0){
            int levelSize = queue.Count;
            
            for(int i = 0; i < levelSize; i++){
                int[] current = queue.Dequeue();

                if(current[0] == n-1 && current[1] == n-1){
                    return pathLength;
                }

                for(int j = 0; j < directions.Length; j++){
                    int row = current[0] + directions[j][0];
                    int col = current[1] + directions[j][1];

                    if(row < 0 || row > n-1 || col < 0 || col > n-1 || grid[row][col] == 1){
                        continue;
                    }

                    queue.Enqueue(new int[]{row, col});
                    grid[row][col] = 1;
                }
            }

            pathLength++;
        }

        return -1;
    }
}
