public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>();
        int result = 0;

        foreach(var op in operations){
            if(op[0] == '+'){
                int temp = stack.Pop();
                int sum = stack.Peek() + temp;
                stack.Push(temp);
                stack.Push(sum);
                result += sum;
            }
            else if(op[0] == 'D'){
                int doubleScore = stack.Peek() * 2;
                stack.Push(doubleScore);
                result += doubleScore;
            }
            else if(op[0] == 'C') result -= stack.Pop();
            else{
                int score = int.Parse(op);
                stack.Push(score);
                result += score;
            }
        }

        return result;
    }
}
