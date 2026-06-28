public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach(var token in tokens){
            if(int.TryParse(token, out int num)) stack.Push(num);
            else{
                int num2 = stack.Pop();
                int num1 = stack.Pop();
                int result;

                if(token == "+") result = num1 + num2;
                else if(token == "-") result = num1 - num2;
                else if(token == "*") result = num1 * num2;
                else result = num1 / num2;

                stack.Push(result);
            }
        }

        return stack.Pop();
    }
}
