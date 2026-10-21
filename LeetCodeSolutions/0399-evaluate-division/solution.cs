public class Solution {
    private Dictionary<string, IList<(string, double)>> _graph = new Dictionary<string, IList<(string, double)>>();

    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        int n = values.Length;

        for(int i = 0; i < n; i++){
            string current = equations[i][0];
            string other = equations[i][1];

            if(!_graph.ContainsKey(current)) _graph[current] = new List<(string, double)>();
            _graph[current].Add((other, values[i]));

            if(!_graph.ContainsKey(other)) _graph[other] = new List<(string, double)>();
            _graph[other].Add((current, 1.0 / values[i]));
        }

        int m = queries.Count;
        double[] result = new double[m];

        for(int i = 0; i < m; i++){
            string current = queries[i][0];
            string target = queries[i][1];

            if(!_graph.ContainsKey(current) || !_graph.ContainsKey(target)) result[i] = -1.0;
            else if(string.Equals(current, target)) result[i] = 1.0;
            else{
                HashSet<string> visited = new HashSet<string>();

                result[i] = DFS(current, target, visited, 1.0);
            }
        }

        return result;
    }

    private double DFS(string current, string target, HashSet<string> visited, double currentResult){
        visited.Add(current);
        
        var currentList = _graph[current];

        foreach(var item in currentList){
            (var other, var value) = item;

            if(visited.Contains(other)) continue;
            
            double newResult = currentResult * value;
            
            if(string.Equals(other, target)) return newResult;

            double latestResult = DFS(other, target, visited, newResult);
            if(latestResult != -1.0) return latestResult;
        }

        return -1.0;
    }
}
