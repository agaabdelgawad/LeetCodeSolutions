public class Solution {
    public int MaxSubArray(int[] nums) {
        int maximumSum = int.MinValue;
        int currentSum = 0;

        for(int i = 0; i < nums.Length; i++){
            currentSum += nums[i];
            maximumSum = Math.Max(maximumSum, currentSum);
            if(currentSum < 0) currentSum = 0;
        }

        return maximumSum;
    }
}
