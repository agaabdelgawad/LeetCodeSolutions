public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var ans = new int[nums.Length * 2];

        nums.CopyTo(ans, 0);
        nums.CopyTo(ans, nums.Length);

        return ans;
    }
}
