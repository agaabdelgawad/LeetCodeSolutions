public class Solution {  
    private IList<string> _result;

    public IList<string> GenerateParenthesis(int n) {
        _result = new List<string>();

        AddParenthesis(new StringBuilder(), 0, 0, n);

        return _result;
    }

    private void AddParenthesis(StringBuilder parentheses, int openCount, int closeCount, int n){
        if(parentheses.Length == n * 2){
            _result.Add(parentheses.ToString());
            return;
        }

        if(openCount < n){
            parentheses.Append("(");
            AddParenthesis(parentheses, openCount + 1, closeCount, n);
            parentheses.Length--;
        }

        if(closeCount < openCount){
            parentheses.Append(")");
            AddParenthesis(parentheses, openCount, closeCount + 1, n);
            parentheses.Length--;
        }
    }
}
