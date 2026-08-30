public class Solution {
    public int[][] Merge(int[][] intervals) {
       if(intervals.Length == 1) return intervals;

        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

        List<int[]> result = new List<int[]>();
        result.Add(intervals[0]);

        foreach(int[] interval in intervals){
            if(interval[0] <= result[result.Count - 1][1]){
                result[result.Count - 1][1] = Math.Max(interval[1], result[result.Count - 1][1]);
            }
            else{
                result.Add(interval);
            }
        }

        return result.ToArray();
    }
}
