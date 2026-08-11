public class Solution {
    public int Rob(int[] nums) {
        int rob1 = 0, rob2 = 0, currentMax = 0;

        foreach (int num in nums) {
            currentMax = Math.Max(num + rob1, rob2);
            rob1 = rob2;
            rob2 = currentMax;
        }
        
        return currentMax;
    }
}
