public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        int i; int j; int sum;
        IList<IList<int>> result = new List<IList<int>>();

        for(int k = 0; k < nums.Length; k++){
            if(nums[k] > 0){
                break;
            }
            
            if(k != 0 && nums[k] == nums[k - 1]){
                continue;
            }
            
            i = k + 1;
            j = nums.Length - 1;
            sum = 0;

            while(i < j){
                sum = nums[k] + nums[i] + nums[j];

                if(sum < 0){
                    i++;
                }
                else if(sum > 0){
                    j--;
                }
                else{
                    result.Add(new List<int>{nums[k], nums[i], nums[j]});
                    i++;
                    j--;

                    while(i < j && nums[i] == nums[i - 1]){
                        i++;
                    }
                    
                    while(i < j && nums[j] == nums[j + 1]){
                        j--;
                    }
                }
            }
        }

        return result;
    }
}
