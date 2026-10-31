public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = 0;
        foreach(int num in nums) sum += num;
        if(sum % 2 == 1) return false;

        int target = sum / 2;

        bool[] reached = new bool[target + 1];
        reached[0] = true;

        foreach(int num in nums){
            for(int i = target; i >= num; i--){
                if(reached[i - num]) reached[i] = true;
                if(reached[target]) return true;
            }
        }

        return false;
    }
}
