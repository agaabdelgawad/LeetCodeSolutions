public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        int m = heights.Length;
        int n = heights[0].Length;
        
        bool[][] pacificVisited = new bool[m][];
        for(int i = 0; i < m; i++) pacificVisited[i] = new bool[n];

        bool[][] atlanticVisited = new bool[m][];
        for(int i = 0; i < m; i++) atlanticVisited[i] = new bool[n];

        for(int i = 0; i < n; i++) DFS(heights, pacificVisited, 0, i, 0);
        for(int i = 0; i < m; i++) DFS(heights, pacificVisited, i, 0, 0);

        for(int i = 0; i < n; i++) DFS(heights, atlanticVisited, m-1, i, 0);
        for(int i = 0; i < m; i++) DFS(heights, atlanticVisited, i, n-1, 0);

        IList<IList<int>> result = new List<IList<int>>();

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(pacificVisited[i][j] && atlanticVisited[i][j]){
                    result.Add(new List<int>(){i, j});
                }
            }
        }

        return result;
    }

    private void DFS(int[][] heights, bool[][] visited, int row, int col, int prevHeight){
        if(row < 0 || row >= heights.Length || col < 0 || col >= heights[0].Length ||
           visited[row][col] || heights[row][col] < prevHeight){
            return;
        }

        visited[row][col] = true;

        DFS(heights, visited, row-1, col, heights[row][col]);
        DFS(heights, visited, row+1, col, heights[row][col]);
        DFS(heights, visited, row, col-1, heights[row][col]);
        DFS(heights, visited, row, col+1, heights[row][col]);
    }
}
