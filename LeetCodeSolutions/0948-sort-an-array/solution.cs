public class Solution{
    public int[] SortArray(int[] nums){
        QuickSort(nums, 0, nums.Length -1);
        return nums;
    }

    private void QuickSort(int[] nums, int left, int right){
        if(left >= right) return;

        if(right == left + 1){
            if(nums[left] > nums[right]) Swap(nums, left, right);
            return;
        }

        int pivot = Partition(nums, left, right);

        QuickSort(nums, left, pivot - 1);
        QuickSort(nums, pivot + 1, right);
    }

    private int Partition(int[] nums, int left, int right){
        int med = left + ((right - left) / 2);

        if(nums[left] > nums[right]) Swap(nums, left, right);
        if(nums[left] > nums[med]) Swap(nums, left, med);
        if(nums[med] > nums[right]) Swap(nums, med, right);

        Swap(nums, med, right - 1);

        int i = left; int j = right - 1;

        while(true){
            while(nums[++i] < nums[right - 1]);
            while(nums[--j] > nums[right - 1]);

            if(i >= j) break;

            Swap(nums, i, j);
        }

        Swap(nums, i, right - 1);
        return i;
    }

    private void Swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
