public class Solution {
    public int LongestConsecutive(int[] nums) {
       if(nums.Length == 0){
            return 0;
        }

        HashSet<int> uniqueSet = new HashSet<int>(nums);
        int result = 1;
        int temp = 1;
        
        foreach(int num in uniqueSet){
            if(uniqueSet.Contains(num - 1)){
                continue;
            }

            while(uniqueSet.Contains(num + temp)){
                temp++;
            }

            result = Math.Max(result, temp);
            temp = 1;
        }

        return result;
    }
}
