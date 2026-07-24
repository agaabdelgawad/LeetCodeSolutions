public class Solution {
    public int[][] Merge(int[][] intervals) {
       if(intervals.Length == 1) return intervals;

        SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();
        foreach(var item in intervals){
            sortedDict[item[0]] = sortedDict.GetValueOrDefault(item[0]) + 1;
            sortedDict[item[1]] = sortedDict.GetValueOrDefault(item[1]) - 1;
        }

        List<int[]> result = new List<int[]>();
        int[] interval = new int[2];
        int have = 0;
        foreach(var kvp in sortedDict){
            if(have == 0) interval[0] = kvp.Key;
            have += kvp.Value;
            if(have == 0){
                interval[1] = kvp.Key;
                result.Add(new int[2] {interval[0], interval[1]});
            }
        }

        return result.ToArray();
    }
}
