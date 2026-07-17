public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> indicesStack = new Stack<int>();
        int[] result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++){
            while(indicesStack.Count > 0 && temperatures[i] > temperatures[indicesStack.Peek()]){
                int previousDayIndex = indicesStack.Pop();
                result[previousDayIndex] = i - previousDayIndex;
            }
            indicesStack.Push(i);
        }

        return result;
    }
}
