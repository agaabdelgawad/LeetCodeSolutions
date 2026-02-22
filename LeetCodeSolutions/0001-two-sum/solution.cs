public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     Dictionary<int,int> map = new Dictionary<int,int>();
     
     for (int i = 0 ; i < nums.Length ; i++)
     {
        int complement = target - nums[i];

        if(map.ContainsKey(complement))
            return new int[2]{map[complement], i};

        map[nums[i]]= i;
     }

     return new int[2]{0,0};
    }
}
