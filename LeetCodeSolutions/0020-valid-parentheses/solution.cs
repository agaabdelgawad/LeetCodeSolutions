public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> bracketDict = new Dictionary<char, char>{
            {')','('},
            {'}','{'},
            {']','['}
        };

        foreach(var bracket in s){
            if(bracketDict.ContainsKey(bracket)){
                if(stack.Count > 0 && bracketDict[bracket] == stack.Peek()) stack.Pop();
                else return false;
            }
            else stack.Push(bracket);
        }
        return stack.Count == 0;
    }
}
