public class Solution {
    public int[] SortArray(int[] nums) {
        int[] result = new int[nums.Length];
        Dictionary<int, int> numCounts = new Dictionary<int, int>();
        int i = 0;
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;

        for(i = 0; i < nums.Length; i++){
            numCounts[nums[i]] = numCounts.GetValueOrDefault(nums[i]) + 1;

            minValue = Math.Min(nums[i], minValue);
            maxValue = Math.Max(nums[i], maxValue);
        }

        i = 0;
        for(int curValue = minValue; curValue <= maxValue; curValue++){
            if(!numCounts.ContainsKey(curValue)){
                continue;
            }

            while(numCounts[curValue]-- > 0){
                result[i++] = curValue;
            }
        }

        return result;
    }
}
