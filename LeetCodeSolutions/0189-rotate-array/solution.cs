public class Solution {
    public void Rotate(int[] nums, int k) {
       int r = k % nums.Length;

        Array.Reverse(nums);
        Array.Reverse(nums, 0, r);
        Array.Reverse(nums, r, nums.Length - r); 
    }
}
