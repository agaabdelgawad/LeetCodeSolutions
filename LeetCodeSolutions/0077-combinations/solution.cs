public class Solution {
    private IList<IList<int>> _result = new List<IList<int>>();

    public IList<IList<int>> Combine(int n, int k) {
        Backtrack(1, n, k, new List<int>());

        return _result;
    }

    private void Backtrack(int start, int n, int k, IList<int> comb){
        if(comb.Count == k) {
            _result.Add(new List<int>(comb));
            return;
        }

        for(int i = start; i <= n; i++){
            comb.Add(i);

            Backtrack(i+1, n, k, comb);

            comb.RemoveAt(comb.Count - 1);
        }
    }
}
