public class Solution {
    public string DecodeString(string s) {
        Stack<string> stringStack = new Stack<string>();
        Stack<int> countStack = new Stack<int>();
        StringBuilder current = new StringBuilder();
        int k = 0;

        foreach(var c in s){
            if(char.IsDigit(c)) k = k * 10 + c - '0';
            else if(c == '['){
                stringStack.Push(current.ToString());
                countStack.Push(k);
                current.Clear();
                k = 0;
            }
            else if(c == ']'){
                string temp = current.ToString();
                int count = countStack.Pop();
                current = new StringBuilder(stringStack.Pop());
                while(count-- > 0) current.Append(temp);
            }
            else current.Append(c);
        }

        return current.ToString();
    }
}
