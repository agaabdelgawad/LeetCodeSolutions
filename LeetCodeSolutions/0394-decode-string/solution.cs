public class Solution {
    public string DecodeString(string s) {
        Stack<string> stringStack = new Stack<string>();
        Stack<int> countStack = new Stack<int>();
        string current = "";
        int k = 0;

        foreach(char c in s){
            if(char.IsDigit(c)) k = k * 10 + (c - '0');
            else if(c == '['){
                stringStack.Push(current);
                countStack.Push(k);
                current = "";
                k = 0;
            }
            else if(c == ']'){
                string temp = current;
                current = stringStack.Pop();
                int count = countStack.Pop();
                while(count > 0){
                    current += temp;
                    count --;
                }
            }
            else{
                current += c;
            }
        }

        return current;
    }
}
