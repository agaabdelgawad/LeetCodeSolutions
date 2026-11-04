public class Solution {
    private IList<IList<int>> _result = new List<IList<int>>();

    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Backtrack(0, candidates, target, new List<int>(), 0);

        return _result;
    }

    private void Backtrack(int start, int[] candidates, int target, IList<int> comb, int currentSum){
        if(currentSum >= target) {
            if(currentSum == target) _result.Add(new List<int>(comb));
            return;
        }

        for(int i = start; i < candidates.Length; i++){
            comb.Add(candidates[i]);

            Backtrack(i, candidates, target, comb, currentSum + candidates[i]);

            comb.RemoveAt(comb.Count - 1);
        }
    }
}
