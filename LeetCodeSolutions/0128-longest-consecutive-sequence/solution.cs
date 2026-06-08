public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;

        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 1;

        foreach (int num in numSet) {
            if (numSet.Contains(num - 1)) continue;
            int currentStreak = 1;
            while (numSet.Contains(num + currentStreak)) currentStreak++;
            if (currentStreak > longestStreak) longestStreak = currentStreak;
        }
        
        return longestStreak;
    }
}
