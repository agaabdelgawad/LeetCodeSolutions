public class Solution {
    public int Jump(int[] nums) {
        // If array is empty or contains only one item
        if (nums.Length <= 1) return 0;

        int maxReach = 0;
        int currentJumpEnd = 0;
        int minJumps = 0;
        int target = nums.Length - 1;

        for (int i = 0; i < target; i++) {
            // Update maximum reach
            if (i + nums[i] > maxReach) maxReach = i + nums[i];

            // Update if reach current jump region enf
            if (i == currentJumpEnd) {
                minJumps++;
                currentJumpEnd = maxReach;

                // Early exit if current jump region end exceeds target
                if (currentJumpEnd >= target) return minJumps;
            }
        }

        return minJumps;
    }
}

