public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];

        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        prefix[0] = 1;
        suffix[nums.Length - 1] = 1;
        int j = nums.Length - 2;

        for(int i = 1; i < nums.Length; i++, j--){
            prefix[i] = prefix[i - 1] * nums[i - 1];
            suffix[j] = suffix[j + 1] * nums[j + 1];
        }

        for(int i = 0; i < answer.Length; i++){
            answer[i] = prefix[i] * suffix[i];
        }

        return answer;
    }
}
