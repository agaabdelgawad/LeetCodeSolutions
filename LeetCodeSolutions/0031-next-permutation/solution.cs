public class Solution {
    public void NextPermutation(int[] nums) {
    int pivot = nums.Length - 2;

    // 1. Find the breaking point from right to left
    while (pivot >= 0 && nums[pivot] >= nums[pivot + 1]) {
        pivot--;
    }

    // 2. If the array is not fully ordered by descending, then find the best replacement, then replace
    if (pivot >= 0) {
        int swapIndex = nums.Length - 1;

        // Search for first number that is higher than pivot from right
        while (nums[swapIndex] <= nums[pivot]) {
            swapIndex--;
        }
        Swap(nums, pivot, swapIndex);
    }

    // 3. Reverse the remaining part on the right of pivot to have the minimum possible order
        Reverse(nums, pivot + 1, nums.Length - 1);
    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            Swap(nums, start++, end--);
        }
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
