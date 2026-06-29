public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i < asteroids.Length; i++){
            if(stack.Count == 0) stack.Push(asteroids[i]);
            else{
                int left = stack.Peek();
                int current = asteroids[i];
                if(left < 0 || current > 0) stack.Push(current);
                else{
                    if(left < Math.Abs(current)){
                        stack.Pop();
                        i--;
                    }
                    else if (left == Math.Abs(current)) stack.Pop();
                }
            }

        }
        
        List<int> result = new List<int>(stack);
        result.Reverse();

        return result.ToArray();
    }
}
