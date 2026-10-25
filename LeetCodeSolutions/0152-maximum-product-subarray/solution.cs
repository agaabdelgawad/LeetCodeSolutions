public class Solution {
    public int MaxProduct(int[] nums) {
        int curMax = nums[0];
        int curMin = nums[0];
        int result = nums[0];

        for(int i = 1; i < nums.Length; i++){
            int tempMax = Math.Max(nums[i], Math.Max(curMax * nums[i], curMin * nums[i]));
            int tempMin = Math.Min(nums[i], Math.Min(curMax * nums[i], curMin * nums[i]));

            curMax = tempMax;
            curMin = tempMin;

            result = Math.Max(result, curMax);
        }

        return result;
    }
}
