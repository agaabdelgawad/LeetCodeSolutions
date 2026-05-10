public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> complements = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++){
            int currentComp = target - nums[i];

            if (complements.Contains(currentComp)){
                return new int[]{Array.IndexOf(nums, currentComp), i};
            }

            complements.Add(nums[i]);
        }

        return new int[]{-1, -1};
    }
}
