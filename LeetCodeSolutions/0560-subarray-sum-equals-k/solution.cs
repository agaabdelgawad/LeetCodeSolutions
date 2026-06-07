public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0;
        int currentPrefixSum = 0;
        int targetPrefixSum;
        Dictionary<int, int> prefixSumCountsDict = new Dictionary<int, int>();
        prefixSumCountsDict[0] = 1;

        for(int i = 0; i < nums.Length; i++){
            currentPrefixSum+= nums[i];
            targetPrefixSum = currentPrefixSum - k;

            if(prefixSumCountsDict.ContainsKey(targetPrefixSum)){
                result+= prefixSumCountsDict[targetPrefixSum];
            }

            prefixSumCountsDict[currentPrefixSum] = prefixSumCountsDict.GetValueOrDefault(currentPrefixSum) + 1;
        }

        return result;
    }
}
