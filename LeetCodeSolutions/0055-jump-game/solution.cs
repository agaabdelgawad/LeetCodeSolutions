public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length;
        int goal = n - 1;

        for(int i = n - 2; i >= 0; i--) if(i + nums[i] >= goal) goal = i;

        return goal == 0;
    }
}

