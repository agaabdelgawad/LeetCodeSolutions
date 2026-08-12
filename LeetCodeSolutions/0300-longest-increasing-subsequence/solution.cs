public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] lengths = new int[nums.Length];
        Array.Fill(lengths, 1);

        int longestSequence = 1;

        for(int i = 1; i < nums.Length; i++){
            for(int j = 0; j < i; j++){
                if(nums[i] > nums[j]) lengths[i] = Math.Max(lengths[i], lengths[j] + 1);
                longestSequence = Math.Max(longestSequence, lengths[i]);
            }
        }

        return longestSequence;
    }
}
