public class Solution {
    public bool CanJump(int[] nums) {
        int target = nums.Length - 1;
        int maxReach = 0;

        // Loop stops automatically if current index exceeds maximum reach
        for (int i = 0; i <= maxReach; i++) {
            // Update maximum reach
            if (i + nums[i] > maxReach) maxReach = i + nums[i];
        
            // Early exit if reach target
            if (maxReach >= target) return true;
        }
    
        return false;
    }
}

