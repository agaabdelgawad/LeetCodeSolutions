public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        while(left < right){
            int mid = left + (right - left) / 2;
            if(mid % 2 == 1) mid = mid - 1;

            if(nums[mid + 1] == nums[mid]) left = mid + 2;
            else right = mid;
        }

        return nums[left];  
    }
}
