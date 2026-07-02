public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
       Array.Sort(position, speed) ;
       Array.Reverse(position);
       Array.Reverse(speed);

       Stack<double> fleetsStack = new Stack<double>();
       for(int i = 0; i < position.Length; i++){
            double timeToTarget = ((double)target - position[i]) / speed[i];
            if(fleetsStack.Count == 0 || timeToTarget > fleetsStack.Peek()){
                fleetsStack.Push(timeToTarget);
            }
       }

       return fleetsStack.Count;
    }
}
