public class Solution {
    private IList<IList<int>> _result;

    public IList<IList<int>> Permute(int[] nums) {
        _result = new List<IList<int>>(){};

        PerformPermutation(0, nums);

        return _result;
    }

    private void PerformPermutation(int startIndex, int[] nums){
	    if(startIndex == nums.Length){
	        _result.Add(new List<int>(nums));
            return;
        }

        for(int i = startIndex; i < nums.Length; i++){
            Swap(i, startIndex, nums);
            PerformPermutation(startIndex + 1, nums);
            Swap(i, startIndex, nums);
        }
    }

    private void Swap(int i, int j, int[] nums){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
