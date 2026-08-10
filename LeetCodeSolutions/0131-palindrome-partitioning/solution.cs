public class Solution {
    private IList<IList<string>> _result;

    public IList<IList<string>> Partition(string s) {
        _result = new List<IList<string>>();

        PerformPartitioning(new List<string>(), 0, s);

        return _result;
    }

    private void PerformPartitioning(IList<string> current, int startIndex, string s){
        if(startIndex == s.Length){
            _result.Add(new List<string>(current));
            return;
        }

        for(int i = startIndex; i < s.Length; i++){
            if(!IsPalindrome(s, startIndex, i)) continue;

            string validSubstring = s.Substring(startIndex, i - startIndex + 1);

            current.Add(validSubstring);

            PerformPartitioning(current, i + 1, s);

            current.RemoveAt(current.Count - 1);
        }
    }

    private bool IsPalindrome(string s, int left, int right) {
        while (left < right){
            if(s[left++] != s[right--]) return false;
        }
        return true;
    }
}

