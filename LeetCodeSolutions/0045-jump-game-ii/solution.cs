public class Solution {
    public int Jump(int[] nums) {
        int maxReach = 0;
        int regionEnd = 0;
        int minJumps = 0;

        for(int i = 0; i < nums.Length - 1; i ++){
            maxReach = Math.Max(maxReach, i + nums[i]);

            if(i == regionEnd){
                minJumps++;
                regionEnd = maxReach;
            }
        }

        return minJumps;
    }
}

