public class Solution {
    private IList<string> _result;
    private string[] _pad = new string[]{"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

    public IList<string> LetterCombinations(string digits) {
        _result = new List<string>();

        if(digits.Length == 0) return _result;

        PerformCombinations(new StringBuilder(), 0, digits);

        return _result;
    }

    private void PerformCombinations(StringBuilder comb, int index, string digits){
        if(index == digits.Length){
            _result.Add(comb.ToString());
            return;
        }

        string currNumberLetters = _pad[digits[index] - '0'];

        for(int i = 0; i < currNumberLetters.Length; i++){
            comb.Append(currNumberLetters[i]);

            PerformCombinations(comb, index + 1, digits);

            comb.Length--;
        }
    }
}

