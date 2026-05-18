public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        Dictionary<int, int> numsCount = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){
            numsCount[nums[i]] = numsCount.GetValueOrDefault(nums[i]) + 1;
        }

        IList<int> result = new List<int>();

        foreach (var kvp in numsCount){
            if (kvp.Value > nums.Length / 3){
                result.Add(kvp.Key);
            }
        }

        return result;
    }
}
