public class Solution {
    private IList<string> _result = new List<string>();

    public IList<string> RestoreIpAddresses(string s) {
        Backtrack(0, s, new List<string>());

        return _result;
    }

    private void Backtrack(int start, string s, IList<string> comb){
        if(comb.Count == 4){
            if(start == s.Length) _result.Add(string.Join(".", comb));
            return;
        }
 
        for(int i = 1; i <= 3; i++){
            if(start + i > s.Length) break;

            string segment = s.Substring(start, i);

            if(segment.StartsWith("0") && segment.Length > 1) continue;
            if(int.Parse(segment) > 255) continue;

            comb.Add(segment);

            Backtrack(start + i, s, comb);

            comb.RemoveAt(comb.Count - 1);
        }
    }
}
