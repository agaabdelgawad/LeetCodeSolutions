public class Solution {
    private Random rand = new Random();

    public int FindKthLargest(int[] nums, int k) {
        k = nums.Length - k;
        return QuickSelect(nums, 0, nums.Length - 1, k);
    }

    private int QuickSelect(int[] nums, int left, int right, int k) {
        while(left <= right){
            int randomPivotIndex = rand.Next(left, right + 1);
            int pivot = nums[randomPivotIndex];

            (int low, int high) = Partition3Way(nums, left, right, pivot);

            if(low <= k && high >= k) return nums[k];
            else if(low > k) right = low - 1;
            else left = high + 1;
        }

        return -1;
    }

    private (int low, int high) Partition3Way(int[] nums, int left, int right, int pivot){
        int low = left;
        int mid = left;
        int high = right;

        while(mid <= high){
            if(nums[mid] < pivot){
                Swap(nums, mid, low);
                mid++;
                low++;
            }
            else if(nums[mid] > pivot){
                Swap(nums, high, mid);
                high--;
            }
            else mid++;
        }

        return (low, high);
    }

    private void Swap(int[] nums, int i, int j){
        int temp = nums[j];
        nums[j] = nums[i];
        nums[i] = temp;
    }
}

