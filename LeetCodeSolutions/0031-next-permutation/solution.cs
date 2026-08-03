public class Solution {
    public void NextPermutation(int[] nums) {
        int n = nums.Length;
        int pivot = n - 2;

        while(pivot >= 0 && nums[pivot] >= nums[pivot + 1]) pivot--;

        if(pivot >= 0){
            int minHigher = n - 1;
            while(minHigher > pivot + 1 && nums[minHigher] <= nums[pivot]) minHigher--;
            Swap(nums, pivot, minHigher);
        }

        int start = pivot + 1;
        int end = n - 1;
        while(start < end) Swap(nums, start++, end--);
    }

    private void Swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
