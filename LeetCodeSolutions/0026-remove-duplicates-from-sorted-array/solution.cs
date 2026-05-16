public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 1;
        int j = 1;

        while (i < nums.Length){
            if (nums[i] != nums[i-1]){
                nums[j] = nums[i];

                j++;
            }

            i++;
        }

        return j;
    }
}
