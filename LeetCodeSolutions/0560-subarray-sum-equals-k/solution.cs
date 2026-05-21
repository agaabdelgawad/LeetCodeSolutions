public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0;
        int currentSum = 0;
        int reqDiff = 0;
        Dictionary<int, int> requiredDiffCount = new Dictionary<int, int>();
        requiredDiffCount[0] = 1;

        for(int i = 0; i < nums.Length; i++){
            currentSum += nums[i];
            reqDiff = currentSum - k;

            if(requiredDiffCount.ContainsKey(reqDiff)){
                result += requiredDiffCount[reqDiff];
            }

            if(!requiredDiffCount.ContainsKey(currentSum)){
                requiredDiffCount[currentSum] = 0;
            }

            requiredDiffCount[currentSum]++;
        }

        return result;
    }
}
