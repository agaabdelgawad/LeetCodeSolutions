public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> numsCounts = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){
            numsCounts[nums[i]] = numsCounts.GetValueOrDefault(nums[i]) + 1;
        }

        return numsCounts.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}
