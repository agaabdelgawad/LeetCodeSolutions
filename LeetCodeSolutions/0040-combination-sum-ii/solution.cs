public class Solution {
    private IList<IList<int>> _result = new List<IList<int>>();
    
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);

        Backtrack(0, candidates, target, new List<int>(), 0);

        return _result;
    }

    private void Backtrack(int start, int[] candidates, int target, IList<int> comb, int currentSum){
        if(currentSum >= target) {
            if(currentSum == target) _result.Add(new List<int>(comb));
            return;
        }

        for(int i = start; i < candidates.Length; i++){
            if(i > start && candidates[i] == candidates[i-1]) continue;
            comb.Add(candidates[i]);

            Backtrack(i+1, candidates, target, comb, currentSum + candidates[i]);

            comb.RemoveAt(comb.Count - 1);
        }
    }
}
