public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        int n = nums.Length;

        for(int k = 0; k < n - 2; k++){
            if(nums[k] > 0) break;
            if(k != 0 && nums[k] == nums[k - 1]) continue;
            
            int i = k + 1; int j = n - 1;

            while(i < j){
                int sum = nums[k] + nums[i] + nums[j];

                if(sum < 0) i++;
                else if(sum > 0) j--;
                else{
                    result.Add(new List<int>{nums[k], nums[i], nums[j]});
                    i++;
                    j--;

                    while(i < j && nums[i] == nums[i - 1]) i++;
                }
            }
        }

        return result; 
    }
}
