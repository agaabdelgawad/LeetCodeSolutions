public class Solution {
    public void SortColors(int[] nums) {
        int zero = 0; int one = 0; int two = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0) zero++;
            else if(nums[i] == 1) one++;
            else two++;
        }

        int index = 0;
        while(zero-- > 0) nums[index++] = 0;
        while(one-- > 0) nums[index++] = 1;
        while(two-- > 0) nums[index++] = 2;
    }
}
