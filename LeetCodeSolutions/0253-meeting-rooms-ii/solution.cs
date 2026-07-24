public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        if(intervals.Length == 0 || intervals.Length == 1) return intervals.Length;

        int maxTime = 0;
        foreach(var interval in intervals){
            maxTime = Math.Max(maxTime, interval[1]);
        }

        int[] timeline = new int[maxTime + 1];
        foreach(var interval in intervals){
            timeline[interval[0]]++;
            timeline[interval[1]]--;
        }

        int result = 0;
        int have = 0;
        for(int i = 0; i < timeline.Length; i++){
            have += timeline[i];
            result = Math.Max(result, have);
        }

        return result;
    }
}
