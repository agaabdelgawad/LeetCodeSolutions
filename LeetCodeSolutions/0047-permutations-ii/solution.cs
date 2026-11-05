public class Solution {
    private IList<IList<int>> _result = new List<IList<int>>();

    public IList<IList<int>> PermuteUnique(int[] nums) {
        Array.Sort(nums);

        Backtrack(nums, new List<int>(), new bool[nums.Length]);

        return _result;
    }

    private void Backtrack(int[] nums, IList<int> comb, bool[] used){
        if(comb.Count == nums.Length){
            _result.Add(new List<int>(comb));
            return;
        }

        for(int i = 0; i < nums.Length; i++){
            if(used[i]) continue;
            if(i > 0 && nums[i] == nums[i-1] && !used[i-1]) continue;

            comb.Add(nums[i]);
            used[i] = true;

            Backtrack(nums, comb, used);

            comb.RemoveAt(comb.Count - 1);
            used[i] = false;
        }
    }
}
