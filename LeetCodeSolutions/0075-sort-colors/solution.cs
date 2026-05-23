public class Solution {
    public void SortColors(int[] nums) {
        int[] colors = new int[3];

        for(int i = 0; i < nums.Length; i++){
            colors[nums[i]]++;
        }

        int value = 0;

        for(int i = 0; i < nums.Length; i++){
            if(i == colors[0]){
                value = 1;
            }

            if(i == colors[0] + colors[1]){
                value = 2;
            }
            
            nums[i] = value;
        }
    }
}
