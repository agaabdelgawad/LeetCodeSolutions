public class Solution{
    public int[] SortArray(int[] nums){
        HeapSort(nums);
        return nums;
    }

    private void HeapSort(int[] nums){
        int n = nums.Length;
        int i;

        for(i = n / 2 - 1; i >= 0; i--){
            Heapify(nums, n, i);
        }

        for(i = n - 1; i >= 0; i--){
            Swap(nums, 0, i);

            Heapify(nums, i, 0);
        }
    }

    private void Heapify(int[] nums, int n, int i){
        int largestNode = i;
        int currentLargest = largestNode;
        int leftChild; int rightChild;

        while(true){
            leftChild = (largestNode * 2) + 1;
            rightChild = (largestNode * 2) + 2;

            if(leftChild < n && nums[leftChild] > nums[currentLargest]) currentLargest = leftChild;
            if(rightChild < n && nums[rightChild] > nums[currentLargest]) currentLargest = rightChild;

            if(currentLargest == largestNode) break;

            Swap(nums, currentLargest, largestNode);
            largestNode = currentLargest;
        }
    }

    private void Swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
