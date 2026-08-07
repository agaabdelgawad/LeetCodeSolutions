public class Solution {
    private IList<IList<int>> _result;

    public IList<IList<int>> Subsets(int[] nums) {
        _result = new List<IList<int>>(){};

        AddSubset(new List<int>(), 0, nums);

        return _result;
    }

    private void AddSubset(IList<int> current, int index, int[] nums){
        _result.Add(new List<int>(current));

        for(int i = index; i < nums.Length; i++){
            current.Add(nums[i]);

            AddSubset(current, i + 1, nums);

            current.RemoveAt(current.Count - 1);
        }
    }
}
